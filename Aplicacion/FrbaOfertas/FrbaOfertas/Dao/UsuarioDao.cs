using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using FrbaOfertas.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace FrbaOfertas.Dao
{
    public class UsuarioDao : UsuarioRepository
    {
        public RolDao RolDao { get { return ServiceDependencies.GetRolDao(); } }

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

            usuario.roles = RolDao.GetByUsername(usuario.userName);
            return usuario;
        }

        public bool ValidateUsuario(string userName,string passWord)
        {

            SqlCommand cmd = new SqlCommand("dbo.SP_VALIDATE_USER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@username", userName));
            cmd.Parameters.Add(new SqlParameter("@passWord", passWord));

            SqlParameter returnParameter = new SqlParameter("@status", SqlDbType.Bit);
            returnParameter.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(returnParameter);
            cmd.ExecuteNonQuery();
            var result = Convert.ToInt32(cmd.Parameters["@status"].Value);

           ConnectionQuery.cerrarConexion();
            return result.Equals(1);
             
         
        }

        public void Create(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_SAVE_USER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@username", usuario.userName));
            cmd.Parameters.Add(new SqlParameter("@pass", usuario.contrasena));
            cmd.Parameters.Add(new SqlParameter("@tipo", usuario.tipoUsuario));
            cmd.Parameters.Add(new SqlParameter("@rol_id", usuario.roles[0].id));

            cmd.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();

            usuario.roles.ForEach(x => CreateRolUsuario(usuario.userName, x));
        }

        private void CreateRolUsuario(string username, Rol rol)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_SAVE_ROL_USUARIO", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@rol_id", rol.id));
            cmd.Parameters.Add(new SqlParameter("@username", username));

            cmd.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }

        public void Update(Usuario usuario)
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

            UpdateRolUsuario(usuario.userName, usuario.roles);
        }

        private void UpdateRolUsuario(string username, List<Rol> roles)
        {
            SqlCommand cmdDeleteRF = new SqlCommand("dbo.SP_DELETE_ROL_USUARIO", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmdDeleteRF.CommandType = CommandType.StoredProcedure;

            cmdDeleteRF.Parameters.Add(new SqlParameter("@username", username));

            cmdDeleteRF.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();

            roles.ForEach(x => CreateRolUsuario(username, x));
        }

        public void Delete(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_DELETE_USER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@username", usuario.userName));

            cmd.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }

        public System.Collections.Generic.List<Usuario> GetAll()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.USUARIO WHERE habilitado = 1", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();

            SqlDataReader r_usuario = cmd.ExecuteReader();

            List<Usuario> usuarios = new List<Usuario>();

            while (r_usuario.Read())
            {
                Usuario usuario = new Usuario();
                usuario.userName = r_usuario["username"].ToString();
                usuario.contrasena = r_usuario["pass"].ToString();
                usuario.tipoUsuario = (TipoUsuario)Convert.ToInt32(r_usuario["tipo"]);
                usuario.habilitado = Convert.ToBoolean(r_usuario["habilitado"]);
                usuario.intento = Convert.ToInt32(r_usuario["intentos"]);
                usuarios.Add(usuario);
            }

            ConnectionQuery.cerrarConexion();

            foreach (Usuario usuario in usuarios) 
            {
                usuario.roles = RolDao.GetByUsername(usuario.userName);
            }

            return usuarios;
        }
    }
}