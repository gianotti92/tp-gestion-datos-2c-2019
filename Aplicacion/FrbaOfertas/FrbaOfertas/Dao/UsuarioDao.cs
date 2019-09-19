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
        public Usuario getUsuario(string nombreUsuario)
        {
            //TODO: aca este sp agarra todos deberia crear un valor especifico para nombre
            SqlCommand cmd = new SqlCommand("dbo.SP_GET_USER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;
           
            SqlDataReader consulta = cmd.ExecuteReader();
            if (!consulta.Read())
            {
                ConnectionQuery.cerrarConexion();
                return null;
            }
            
            Usuario usuario = new Usuario();
            usuario.id = consulta.GetInt32(0);
            usuario.userName = consulta.GetString(1);
            usuario.tipoUsuario = (TipoUsuario)consulta.GetInt32(2);
            usuario.contrasena = consulta.GetString(3);
            usuario.estadoUsuario = (EstadoUsuario)consulta.GetInt32(4);
            usuario.intento = consulta.GetInt32(5);

            ConnectionQuery.cerrarConexion();
            return usuario;
        }

        public Usuario getUsuario(int id)
        {
            //TODO: aca este sp agarra todos deberia crear un valor especifico para id
            SqlCommand cmd = new SqlCommand("dbo.SP_GET_USER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader consulta = cmd.ExecuteReader();
            if (!consulta.Read())
            {
                ConnectionQuery.cerrarConexion();
                return null;
            }

            Usuario usuario = new Usuario();
            usuario.id = consulta.GetInt32(0);
            usuario.userName = consulta.GetString(1);
            usuario.tipoUsuario = (TipoUsuario)consulta.GetInt32(2);
            usuario.contrasena = consulta.GetString(3);
            usuario.estadoUsuario = (EstadoUsuario)consulta.GetInt32(4);
            usuario.intento = consulta.GetInt32(5);

            ConnectionQuery.cerrarConexion();
            return usuario;
        }


        public void saveUsuario(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_UPDATE_USER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@id_usuario", usuario.id));
            cmd.Parameters.Add(new SqlParameter("@contrasena", usuario.contrasena));
            cmd.Parameters.Add(new SqlParameter("@estado_usuario", usuario.estadoUsuario));
            cmd.Parameters.Add(new SqlParameter("@nombre", usuario.userName));
            cmd.Parameters.Add(new SqlParameter("@tipo_usuario", usuario.tipoUsuario));
            cmd.Parameters.Add(new SqlParameter("@intentos", usuario.intento));

            cmd.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
    }
}