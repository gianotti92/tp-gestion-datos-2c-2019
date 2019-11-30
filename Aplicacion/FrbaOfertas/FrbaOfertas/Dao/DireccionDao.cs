using System.Data;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using System;

namespace FrbaOfertas.Dao
{
    public class DireccionDao : DireccionRepository
    {
        public Direccion GetById(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.DIRECCION WHERE id = @id", ConnectionQuery.Instance());

                            ConnectionQuery.abrirConexion();
           

            cmd.Parameters.Add("@id", SqlDbType.VarChar);
            cmd.Parameters["@id"].Value = id;

            SqlDataReader r_direccion = cmd.ExecuteReader();

            Direccion direccion = new Direccion();

            if (r_direccion.Read())
            {
                direccion.id = Convert.ToInt32(r_direccion["id"]);
                direccion.calle = r_direccion["CALLE"].ToString();
                direccion.nro = r_direccion["NUMERO"].ToString();
                direccion.piso = r_direccion["PISO"].ToString();
                direccion.depto = r_direccion["DPTO"].ToString();
                direccion.localidad = r_direccion["LOCALIDAD"].ToString();
                if (!string.IsNullOrEmpty(r_direccion["CIUDAD"].ToString()))
                    direccion.ciudad = Convert.ToInt32(r_direccion["CIUDAD"]);
                direccion.codigoPostal = Convert.ToInt32(r_direccion["CODIGO_POSTAL"]);
            }

          
                ConnectionQuery.cerrarConexion();
           
            return direccion;
        }

        public Direccion createDireccion(Direccion direccion)
        {
            SqlCommand cmd_direccion = new SqlCommand("dbo.SP_SAVE_DIRECCION", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_direccion.CommandType = CommandType.StoredProcedure;

            cmd_direccion.Parameters.Add("@calle", direccion.calle);
            cmd_direccion.Parameters.Add("@nro", direccion.nro);
            cmd_direccion.Parameters.Add("@piso", direccion.piso);
            cmd_direccion.Parameters.Add("@depto", direccion.depto);
            cmd_direccion.Parameters.Add("@localidad", direccion.localidad);
            cmd_direccion.Parameters.Add("@id_cod_postal", direccion.codigoPostal);
            
            int id = Convert.ToInt32(cmd_direccion.ExecuteScalar());

            direccion.id = id;
            ConnectionQuery.cerrarConexion();

            return direccion;
        }

        public int createCodigoPostal(string codigoPostal)
        {
            SqlCommand cmd_postalCode = new SqlCommand("dbo.SP_SAVE_POSTAL_CODE", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_postalCode.CommandType = CommandType.StoredProcedure;
            cmd_postalCode.Parameters.Add("@descripcion",codigoPostal);
            int id_postal_code = cmd_postalCode.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();

            return id_postal_code;
        }

        public void updateDireccion(Direccion direccion)
        {
            SqlCommand cmd_direccion = new SqlCommand("dbo.SP_UPDATE_DIRECCION", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_direccion.CommandType = CommandType.StoredProcedure;

            cmd_direccion.Parameters.Add("@id", direccion.id);
            cmd_direccion.Parameters.Add("@calle", direccion.calle);
            cmd_direccion.Parameters.Add("@nro", direccion.nro);
            cmd_direccion.Parameters.Add("@piso", direccion.piso);
            cmd_direccion.Parameters.Add("@dpto", direccion.depto);
            cmd_direccion.Parameters.Add("@localidad", direccion.localidad);
            cmd_direccion.Parameters.Add("@cp", direccion.codigoPostal);
           
            cmd_direccion.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
    }
}