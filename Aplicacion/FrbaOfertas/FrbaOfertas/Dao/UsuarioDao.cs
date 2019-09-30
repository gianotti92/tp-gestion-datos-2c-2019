using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace FrbaOfertas.Dao
{
    public class UsuarioDao : UsuarioRepository
    {
        public Usuario getUsuario(string userName)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_GET_USER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@username", userName));
           
            SqlDataReader consulta = cmd.ExecuteReader();
            if (!consulta.Read())
            {
                ConnectionQuery.cerrarConexion();
                return null;
            }
            
            Usuario usuario = new Usuario();
            usuario.userName = consulta.GetString(0);
            usuario.tipoUsuario = (TipoUsuario)consulta.GetInt32(1);
            usuario.contrasena = consulta.GetString(2);
            usuario.habilitado = consulta.GetBoolean(3);
            usuario.intento = consulta.GetInt32(4);

            ConnectionQuery.cerrarConexion();
            return usuario;
        }

        public void saveUsuario(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_UPDATE_USER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@username", usuario.userName));
            cmd.Parameters.Add(new SqlParameter("@pass", usuario.contrasena));
            cmd.Parameters.Add(new SqlParameter("@habilitado", usuario.habilitado));
            cmd.Parameters.Add(new SqlParameter("@tipo", usuario.tipoUsuario));
            cmd.Parameters.Add(new SqlParameter("@intentos", usuario.intento));

            cmd.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
    }
}