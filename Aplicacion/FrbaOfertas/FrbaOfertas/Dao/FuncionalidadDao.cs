﻿using System.Collections.Generic;
 using FrbaOfertas.Entities;
 using FrbaOfertas.Repository;
using FrbaOfertas.Connection;
using System.Data.SqlClient;
using System.Data;
using System;

 namespace FrbaOfertas.Dao
{
    public class FuncionalidadDao : FuncionalidadRepository
    {

        public List<Funcionalidad> searchFuncionalidad(Usuario usuario)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_GET_FUNCTIONALITY_BY_USER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@username", usuario.userName));

            SqlDataReader consulta = cmd.ExecuteReader();

            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            while(consulta.Read())
            {
            	Funcionalidad funcionalidad = new Funcionalidad();
            	funcionalidad.id = consulta.GetInt32(0);
            	funcionalidad.nombre = consulta.GetString(1);

            	funcionalidades.Add(funcionalidad);

            }

            ConnectionQuery.cerrarConexion();

            return funcionalidades;
        }

        public Funcionalidad GetById(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.FUNCIONALIDAD WHERE id = " + id, ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();

            SqlDataReader r_funcionalidad = cmd.ExecuteReader();

            Funcionalidad funcionalidad = new Funcionalidad();

            if (r_funcionalidad.Read())
            {
                funcionalidad.id = Convert.ToInt32(r_funcionalidad["id"]);
                funcionalidad.nombre = r_funcionalidad["nombre"].ToString();
            }

            ConnectionQuery.cerrarConexion();

            return funcionalidad;
        }
    }
}