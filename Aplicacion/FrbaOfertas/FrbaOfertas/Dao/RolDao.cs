﻿using System.Collections.Generic;
 using FrbaOfertas.Entities;
 using FrbaOfertas.Repository;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using System.Data;
using System;

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
                rol.estado = (EstadoRol)r_rol["estado"];

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
            cmdRol.Parameters.Add(new SqlParameter("@estado", rol.estado));

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

        public List<Rol> searchRoles(string usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}