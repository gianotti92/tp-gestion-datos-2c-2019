using System;
using System.Data;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Dao
{
    public class ClienteDao : ClienteRepository
    {
        public void guardarCliente(Cliente cliente)
        {
            int id_postal_code;
            int id_direccion;
            SqlCommand cmd_postalCode = new SqlCommand("dbo.SP_SAVE_POSTAL_CODE", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_postalCode.CommandType = CommandType.StoredProcedure;
            id_postal_code = Convert.ToInt32(cmd_postalCode.ExecuteScalar());
            cmd_postalCode.Parameters.Add("@id", id_postal_code);
            cmd_postalCode.Parameters.Add("@descripcion", cliente.direccion.codigoPostal);
            cmd_postalCode.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();

            SqlCommand cmd_direccion = new SqlCommand("dbo.SP_SAVE_DIRECCION", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_direccion.CommandType = CommandType.StoredProcedure;
            id_direccion = Convert.ToInt32(cmd_direccion.ExecuteScalar());

            cmd_direccion.Parameters.Add("@direccion_id", id_direccion);
            cmd_direccion.Parameters.Add("@calle", cliente.direccion.calle);
            cmd_direccion.Parameters.Add("@nro", cliente.direccion.nro);
            cmd_direccion.Parameters.Add("@piso", cliente.direccion.piso);
            cmd_direccion.Parameters.Add("@depto", cliente.direccion.depto);
            cmd_direccion.Parameters.Add("@localidad", cliente.direccion.localidad);
            cmd_direccion.Parameters.Add("@id_cod_postal", id_postal_code);
            ConnectionQuery.cerrarConexion();
            
            SqlCommand cmd_client = new SqlCommand("dbo.SP_SAVE_CLIENT", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_client.CommandType = CommandType.StoredProcedure;
            int clientId = Convert.ToInt32(cmd_client.ExecuteScalar());
            cmd_client.Parameters.Add(new SqlParameter("@id", clientId));
            cmd_client.Parameters.Add(new SqlParameter("@nombre", cliente.nombre));
            cmd_client.Parameters.Add(new SqlParameter("@apellido", cliente.apellido));
            cmd_client.Parameters.Add(new SqlParameter("@dni", cliente.dni));
            cmd_client.Parameters.Add(new SqlParameter("@mail", cliente.mail));
            cmd_client.Parameters.Add(new SqlParameter("@fechaNac", cliente.fechaNac));
            cmd_client.Parameters.Add(new SqlParameter("@direccion_id", id_direccion));
            cmd_client.Parameters.Add(new SqlParameter("@calle", cliente.direccion.calle));
            cmd_client.Parameters.Add(new SqlParameter("@nro", cliente.direccion.nro));
            cmd_client.Parameters.Add(new SqlParameter("@piso", cliente.direccion.nro));
            cmd_client.Parameters.Add(new SqlParameter("@depto", cliente.direccion.depto));
            cmd_client.Parameters.Add(new SqlParameter("@localidad", cliente.direccion.localidad));
            cmd_client.Parameters.Add(new SqlParameter("@codigoPostal", cliente.direccion.codigoPostal));
            cmd_client.Parameters.Add(new SqlParameter("@id_cod_postal", id_postal_code));

            cmd_client.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
    }
}