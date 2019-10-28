using System.Data;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Dao
{
    public class DireccionDao : DireccionRepository
    {
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
            
            int id = cmd_direccion.ExecuteNonQuery();

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
    }
}