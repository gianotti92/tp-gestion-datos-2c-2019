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

        public List<Rol> searchRoles(string usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}