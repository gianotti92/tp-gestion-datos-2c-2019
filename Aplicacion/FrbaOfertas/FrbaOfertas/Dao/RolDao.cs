﻿﻿using System.Collections.Generic;
 using FrbaOfertas.Entities;
 using FrbaOfertas.Repository;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using System.Data;
using System;
 using System.Text;

 namespace FrbaOfertas.Dao
{
    public class RolDao : RolRepository
    {
        public Rol GetById(int id)
        {
            SqlCommand cmd_rol = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.ROL WHERE id = " + id, ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();

            SqlDataReader r_rol = cmd_rol.ExecuteReader();

            Rol rol = new Rol();

            if (r_rol.Read())
            {
                rol.id = Convert.ToInt32(r_rol["id"]);
                rol.nombre = r_rol["nombre"].ToString();
                rol.activo = Convert.ToBoolean(r_rol["estado"]);

                SqlCommand cmd_funcionalidad = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.FUNCIONALIDAD f " +
                                                              "JOIN GESTION_BDD_2C_2019.ROL_FUNCIONALIDAD rf " +
                                                              "ON f.id = rf.funcionalidad_id " +
                                                              "WHERE rf.rol_id = " + id, ConnectionQuery.Instance());

                r_rol.Close();

                SqlDataReader r_funcionalidad = cmd_funcionalidad.ExecuteReader();

                while (r_funcionalidad.Read())
                {
                    Funcionalidad funcionalidad = new Funcionalidad();

                    funcionalidad.id = Convert.ToInt32(r_funcionalidad["id"]);
                    funcionalidad.nombre = r_funcionalidad["nombre"].ToString();

                    rol.funcionalidades.Add(funcionalidad);
                }
            }

            ConnectionQuery.cerrarConexion();

            return rol;
        }

        public void Create(Rol rol)
        {
            SqlCommand cmdRol = new SqlCommand("dbo.SP_CREATE_ROL", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmdRol.CommandType = CommandType.StoredProcedure;

            cmdRol.Parameters.Add(new SqlParameter("@nombre", rol.nombre));

            int idRol = Convert.ToInt32(cmdRol.ExecuteScalar());

            foreach (Funcionalidad funcionalidad in rol.funcionalidades)
            {
                SqlCommand cmdFuncionalidad = new SqlCommand("dbo.SP_CREATE_ROL_FUNCIONALIDAD", ConnectionQuery.Instance());
                cmdFuncionalidad.CommandType = CommandType.StoredProcedure;

                cmdFuncionalidad.Parameters.Add("@rol_id", idRol);
                cmdFuncionalidad.Parameters.Add("@funcionalidad_id", funcionalidad.id);

                cmdFuncionalidad.ExecuteNonQuery();
            }

            ConnectionQuery.cerrarConexion();
        }

        public void Update(Rol rol)
        {
            SqlCommand cmdRol = new SqlCommand("dbo.SP_UPDATE_ROL", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmdRol.CommandType = CommandType.StoredProcedure;

            cmdRol.Parameters.Add(new SqlParameter("@id", rol.id));
            cmdRol.Parameters.Add(new SqlParameter("@nombre", rol.nombre));
            cmdRol.Parameters.Add(new SqlParameter("@estado", rol.activo));

            cmdRol.ExecuteNonQuery();

            SqlCommand cmdDeleteRF = new SqlCommand("dbo.SP_DELETE_ROL_FUNCIONALIDAD", ConnectionQuery.Instance());
            cmdDeleteRF.CommandType = CommandType.StoredProcedure;

            cmdDeleteRF.Parameters.Add(new SqlParameter("@rol_id", rol.id));

            cmdDeleteRF.ExecuteNonQuery();

            foreach (Funcionalidad funcionalidad in rol.funcionalidades)
            {
                SqlCommand cmdFuncionalidad = new SqlCommand("dbo.SP_CREATE_ROL_FUNCIONALIDAD", ConnectionQuery.Instance());
                cmdFuncionalidad.CommandType = CommandType.StoredProcedure;

                cmdFuncionalidad.Parameters.Add("@rol_id", rol.id);
                cmdFuncionalidad.Parameters.Add("@funcionalidad_id", funcionalidad.id);

                cmdFuncionalidad.ExecuteNonQuery();
            }

            ConnectionQuery.cerrarConexion();
        }

        public List<Rol> searchRoles()
        {
            SqlCommand cmd_rol = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.ROL" , ConnectionQuery.Instance());
            
            ConnectionQuery.abrirConexion();
            SqlDataReader r_rol = cmd_rol.ExecuteReader();
            List<Rol> roles = new List<Rol>();

            while (r_rol.Read())
            {
                Rol rol = new Rol();
                rol.id = Convert.ToInt32(r_rol["id"]);
                rol.nombre = r_rol["nombre"].ToString();
                rol.activo = Convert.ToBoolean(r_rol["estado"]);
                roles.Add(rol);
            }
            ConnectionQuery.cerrarConexion();
            r_rol.Close();
            return roles;
        }

        public List<Rol> searchRoles(string nombre, int estado)
        {    
            StringBuilder builder = new StringBuilder("SELECT * FROM GESTION_BDD_2C_2019.ROL ");
            
            /*salen del combo del filtro estado 1 = activo, estado 2 = inactivo se puede mejorar pero ble*/
            if (!string.IsNullOrEmpty(nombre) || estado == 1 || estado == 2)
            {
                builder.Append("WHERE ");
            }

            if (!string.IsNullOrEmpty(nombre))
            {
                builder.Append("NOMBRE LIKE '%" + nombre + "%'");
                if (estado == 1 || estado == 2)
                {
                    builder.Append(" AND ");
                }
            }
            
            if (estado == 1)
            {
                builder.Append("ESTADO = 1");
            }

            if (estado == 2)
            {
                builder.Append("ESTADO = 2");
            }

            SqlCommand cmd_rol = new SqlCommand( builder.ToString(), ConnectionQuery.Instance());
            
            ConnectionQuery.abrirConexion();
            SqlDataReader r_rol = cmd_rol.ExecuteReader();
            List<Rol> roles = new List<Rol>();

            while (r_rol.Read())
            {
                Rol rol = new Rol();
                rol.id = Convert.ToInt32(r_rol["id"]);
                rol.nombre = r_rol["nombre"].ToString();
                rol.activo = Convert.ToBoolean(r_rol["estado"]);
                roles.Add(rol);
            }
            ConnectionQuery.cerrarConexion();
            r_rol.Close();
            return roles;
        }

        public void eliminar(Rol rolAEliminar)
        {
            
            SqlCommand cmdFuncionalidad = new SqlCommand("dbo.SP_DELETE_ROL", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmdFuncionalidad.CommandType = CommandType.StoredProcedure;

            cmdFuncionalidad.Parameters.Add("@rol_id", rolAEliminar.id);
            cmdFuncionalidad.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }


        public List<Rol> GetByUsername(string username)
        {
            SqlCommand cmd_rol_usuario = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.ROL_USUARIO WHERE username = @username", ConnectionQuery.Instance());

            ConnectionQuery.abrirConexion();

            cmd_rol_usuario.Parameters.Add("@username", SqlDbType.VarChar);
            cmd_rol_usuario.Parameters["@username"].Value = username;

            SqlDataReader r_rol_usuario = cmd_rol_usuario.ExecuteReader();
            List<int> idRoles = new List<int>();

            while (r_rol_usuario.Read())
            {
                idRoles.Add(Convert.ToInt32(r_rol_usuario["rol_id"]));
            }
            ConnectionQuery.cerrarConexion();
            r_rol_usuario.Close();

            List<Rol> roles = new List<Rol>();

            foreach (int idRol in idRoles)
            {
                roles.Add(GetById(idRol));
            }

            return roles;
        }

        public List<Rol> GetAll()
        {
            SqlCommand cmd_rol = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.ROL WHERE estado = 1", ConnectionQuery.Instance());

            ConnectionQuery.abrirConexion();
            SqlDataReader r_rol = cmd_rol.ExecuteReader();

            List<int> idRoles = new List<int>();

            while (r_rol.Read())
            {
                idRoles.Add(Convert.ToInt32(r_rol["id"]));
            }
            ConnectionQuery.cerrarConexion();
            r_rol.Close();

            List<Rol> roles = new List<Rol>();

            foreach (int idRol in idRoles)
            {
                roles.Add(GetById(idRol));
            }

            return roles;
        }
    }
}