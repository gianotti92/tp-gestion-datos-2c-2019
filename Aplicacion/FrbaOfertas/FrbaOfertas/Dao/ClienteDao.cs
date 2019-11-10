﻿using System;
using System.Data;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using FrbaOfertas.Service;

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

        public Cliente GetByUsername(string username)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.CLIENTE WHERE USUARIO = @username", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();

            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;

            SqlDataReader r_cliente = cmd.ExecuteReader();

            int idDireccion = 0;

            Cliente cliente = new Cliente();

            if (r_cliente.Read())
            {
                cliente.id = Convert.ToInt32(r_cliente["ID"]);
                cliente.dni = Convert.ToInt32(r_cliente["DNI"]);
                cliente.nombre = r_cliente["NOMBRE"].ToString();
                cliente.apellido = r_cliente["APELLIDO"].ToString();
                cliente.mail = r_cliente["MAIL"].ToString();
                cliente.telefono = Convert.ToInt32(r_cliente["TELEFONO"]);
                cliente.fechaNac = r_cliente["FNANCIAMIENTO"].ToString();
                cliente.usuario = r_cliente["USUARIO"].ToString();
                cliente.saldo = Convert.ToDouble(r_cliente["SALDO"]);
                idDireccion = Convert.ToInt32(r_cliente["DIRECCION"]);
            }

            ConnectionQuery.cerrarConexion();

            Direccion direccion = ServiceDependencies.getDireccionDao().GetById(idDireccion);

            cliente.direccion = direccion;

            return cliente;
        }


        public void Update(Cliente cliente)
        {
            SqlCommand cmd_client = new SqlCommand("dbo.SP_UPDATE_CLIENTE", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_client.CommandType = CommandType.StoredProcedure;

            cmd_client.Parameters.Add(new SqlParameter("@id", cliente.id));
            cmd_client.Parameters.Add(new SqlParameter("@nombre", cliente.nombre));
            cmd_client.Parameters.Add(new SqlParameter("@apellido", cliente.apellido));
            cmd_client.Parameters.Add(new SqlParameter("@dni", cliente.dni));
            cmd_client.Parameters.Add(new SqlParameter("@mail", cliente.mail));
            cmd_client.Parameters.Add(new SqlParameter("@fechaNac", Convert.ToDateTime(cliente.fechaNac)));
            cmd_client.Parameters.Add(new SqlParameter("@direccion_id", cliente.direccion.id));
            cmd_client.Parameters.Add(new SqlParameter("@telefono", cliente.telefono));
            cmd_client.Parameters.Add(new SqlParameter("@usuario_id", cliente.usuario));
            cmd_client.Parameters.Add(new SqlParameter("@saldo", cliente.saldo));

            cmd_client.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
    }
}