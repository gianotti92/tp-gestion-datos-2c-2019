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
            SqlCommand cmd_client = new SqlCommand("dbo.SP_SAVE_CLIENT", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_client.CommandType = CommandType.StoredProcedure;
            cmd_client.Parameters.Add(new SqlParameter("@nombre", cliente.nombre));
            cmd_client.Parameters.Add(new SqlParameter("@apellido", cliente.apellido));
            cmd_client.Parameters.Add(new SqlParameter("@dni", cliente.dni));
            cmd_client.Parameters.Add(new SqlParameter("@mail", cliente.mail));
            cmd_client.Parameters.Add(new SqlParameter("@fechaNac", Convert.ToDateTime(cliente.fechaNac)));
            cmd_client.Parameters.Add(new SqlParameter("@direccion_id", cliente.direccion.id));
            cmd_client.Parameters.Add(new SqlParameter("@telefono", cliente.telefono));
            cmd_client.Parameters.Add(new SqlParameter("@usuario_id", cliente.usuario));
            
            cmd_client.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
    }
}