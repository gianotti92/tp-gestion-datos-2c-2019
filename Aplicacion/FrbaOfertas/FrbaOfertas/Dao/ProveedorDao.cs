﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using FrbaOfertas.Service;

namespace FrbaOfertas.Dao
{
    public class ProveedorDao : ProovedorRepository
    {
        public List<Proovedor> searchProovedores()
        {

            SqlCommand cmd_oferta = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.PROVEEDOR" , ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            SqlDataReader r_proovedor = cmd_oferta.ExecuteReader();
            List<Proovedor> proovedores = new List<Proovedor>();

            int idDIreccion = 0;
         
            while (r_proovedor.Read())
            {

                if (ConnectionQuery.conexion == null)
                {
                    ConnectionQuery.abrirConexion();
                }
                Proovedor proovedor = new Proovedor();
                proovedor.id = Convert.ToInt32(r_proovedor["ID"]);
                proovedor.cuit = Convert.ToString(r_proovedor["CUIT"]);
                proovedor.razonSocial = Convert.ToString(r_proovedor["RAZON_SOCIAL"]);
                proovedor.mail = Convert.ToString(r_proovedor["MAIL"]);
                proovedor.telefono = Convert.ToInt32(r_proovedor["TELEFONO"]);
                proovedor.contacto = Convert.ToString(r_proovedor["CONTACTO"]);
                proovedor.usuario = Convert.ToString(r_proovedor["USUARIO"]);
                proovedor.rubro = Convert.ToInt32(r_proovedor["RUBRO"]);
                Direccion direccion = new Direccion();
                direccion.id = Convert.ToInt32(r_proovedor["DIRECCION"]);
                //Direccion direccion = ServiceDependencies.getDireccionDao().GetById(idDIreccion);
                proovedor.direccion = direccion;
                proovedores.Add(proovedor);
            }
            ConnectionQuery.cerrarConexion();

              proovedores.ForEach(p => p.direccion= ServiceDependencies.getDireccionDao().GetById(p.direccion.id));

            return proovedores;
        }

        public Proovedor getProveedor(int idVendor)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_GET_VENDOR", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@idVendor", idVendor));

            SqlDataReader consulta = cmd.ExecuteReader();
            if (!consulta.Read())
            {
                ConnectionQuery.cerrarConexion();
                return null;
            }

            Proovedor unProveedor = new Proovedor();
            unProveedor.id = (int)consulta.GetDouble(0);
            unProveedor.cuit = consulta.GetString(1);
            unProveedor.razonSocial = consulta.GetString(2);
            unProveedor.mail = consulta.GetString(3);
            unProveedor.telefono = consulta.GetInt32(4);
            unProveedor.rubro = consulta.GetInt32(6);
            unProveedor.contacto = consulta.GetString(7);
            unProveedor.usuario = consulta.GetString(8);

            ConnectionQuery.cerrarConexion();

            return unProveedor;
        }

        public Proovedor getProveedorConUsuario(string usuarioProveedor)
        {
            SqlCommand cmd = new SqlCommand("select * from GESTION_BDD_2C_2019.PROVEEDOR  where USUARIO = @username", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();

            cmd.Parameters.Add("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = usuarioProveedor;

            SqlDataReader r_proveedor = cmd.ExecuteReader();

            int idDireccion = 0;

            Proovedor unProveedor = new Proovedor();

            if (r_proveedor.Read())
            {
                unProveedor.id = Convert.ToInt32(r_proveedor["ID"]);
                unProveedor.cuit = r_proveedor["CUIT"].ToString();
                unProveedor.razonSocial = r_proveedor["RAZON_SOCIAL"].ToString();
                unProveedor.mail = r_proveedor["MAIL"].ToString();
                unProveedor.telefono = Convert.ToInt32(r_proveedor["TELEFONO"]);
                unProveedor.rubro = Convert.ToInt32( r_proveedor["RUBRO"]);
                unProveedor.contacto = r_proveedor["CONTACTO"].ToString();
                unProveedor.usuario = r_proveedor["USUARIO"].ToString();
                idDireccion = Convert.ToInt32(r_proveedor["DIRECCION"]);
            }

            ConnectionQuery.cerrarConexion();

            Direccion direccion = ServiceDependencies.getDireccionDao().GetById(idDireccion);

            unProveedor.direccion = direccion;

            return unProveedor;
        }

        public List<Proovedor> searchProovedoresPorFiltro(string razonsocialFiltro, string cuitFiltro, string mailFiltro)
        {
            StringBuilder builder = new StringBuilder("SELECT * FROM GESTION_BDD_2C_2019.PROVEEDOR ");
            
            List<Proovedor> proovedors = new List<Proovedor>();

            if (!string.IsNullOrEmpty(razonsocialFiltro)
                || !string.IsNullOrEmpty(cuitFiltro)
                || !string.IsNullOrEmpty(mailFiltro))
            {

                builder.Append("WHERE ");

                if (!string.IsNullOrEmpty(razonsocialFiltro))
                {
                    builder.Append("RAZON_SOCIAL LIKE '%" + razonsocialFiltro + "%' ");
                }

                if (!string.IsNullOrEmpty(cuitFiltro))
                {
                    if (!string.IsNullOrEmpty(razonsocialFiltro))
                        builder.Append("AND ");

                    builder.Append("CUIT = '" + cuitFiltro + "' ");
                }

                if (!string.IsNullOrEmpty(mailFiltro))
                {
                    if (!string.IsNullOrEmpty(razonsocialFiltro) || !string.IsNullOrEmpty(cuitFiltro))
                        builder.Append("AND ");

                    builder.Append("MAIL LIKE '%" + mailFiltro + "%'");
                }

                String query = builder.ToString();


                SqlCommand cmd = new SqlCommand(builder.ToString(),
                    ConnectionQuery.Instance());
                ConnectionQuery.abrirConexion();

                SqlDataReader r_proveedor = cmd.ExecuteReader();

                int idDireccion = 0;

                Dictionary<int, int> diccionarioIdProveedorIdDireccion = new Dictionary<int, int>();
                
                while (r_proveedor.Read())
                {
                    Proovedor unProveedor = new Proovedor();
                    unProveedor.id = Convert.ToInt32(r_proveedor["ID"]);
                    unProveedor.cuit = r_proveedor["CUIT"].ToString();
                    unProveedor.razonSocial = r_proveedor["RAZON_SOCIAL"].ToString();
                    unProveedor.mail = r_proveedor["MAIL"].ToString();
                    unProveedor.telefono = Convert.ToInt32(r_proveedor["TELEFONO"]);
                    unProveedor.rubro = Convert.ToInt32( r_proveedor["RUBRO"]);
                    unProveedor.contacto = r_proveedor["CONTACTO"].ToString();
                    unProveedor.usuario = r_proveedor["USUARIO"].ToString();
                    idDireccion = Convert.ToInt32(r_proveedor["DIRECCION"]);
                    diccionarioIdProveedorIdDireccion.Add(unProveedor.id, idDireccion);
                    
                    proovedors.Add(unProveedor);
                }

                ConnectionQuery.cerrarConexion();

                proovedors.ForEach(x =>
                {
                    idDireccion = diccionarioIdProveedorIdDireccion[x.id];
                    x.direccion = ServiceDependencies.getDireccionDao().GetById(idDireccion);
                });
            }

            return proovedors;
        }

        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand("dbo.SP_ELIMINAR_PROVEEDOR", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", id));
            cmd.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }

        public void update(Proovedor proveedor)
        {
            
            SqlCommand cmd_proveedor = new SqlCommand("dbo.SP_UPDATE_PROVIDER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_proveedor.CommandType = CommandType.StoredProcedure;
            cmd_proveedor.Parameters.Add(new SqlParameter("@razonSocial", proveedor.razonSocial));
            cmd_proveedor.Parameters.Add(new SqlParameter("@tel", proveedor.telefono));
            cmd_proveedor.Parameters.Add(new SqlParameter("@direc", proveedor.direccion.id));
            cmd_proveedor.Parameters.Add(new SqlParameter("@ciut", proveedor.cuit));
            cmd_proveedor.Parameters.Add(new SqlParameter("@rubro", proveedor.rubro));
            cmd_proveedor.Parameters.Add(new SqlParameter("@mail", proveedor.mail));
            cmd_proveedor.Parameters.Add(new SqlParameter("@contacto", proveedor.contacto));
            cmd_proveedor.Parameters.Add(new SqlParameter("@id_prov", proveedor.id));
            
            cmd_proveedor.Parameters.Add(new SqlParameter("@calle", proveedor.direccion.calle));
            cmd_proveedor.Parameters.Add(new SqlParameter("@nro", proveedor.direccion.nro));
            cmd_proveedor.Parameters.Add(new SqlParameter("@piso", proveedor.direccion.piso));
            cmd_proveedor.Parameters.Add(new SqlParameter("@dpto", proveedor.direccion.depto));
            cmd_proveedor.Parameters.Add(new SqlParameter("@localidad", proveedor.direccion.localidad));
            cmd_proveedor.Parameters.Add(new SqlParameter("@cp", proveedor.direccion.codigoPostal));
            cmd_proveedor.Parameters.Add(new SqlParameter("@ciudad", proveedor.direccion.ciudad));
            
            cmd_proveedor.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }

        public void save(Proovedor proveedor)
        {
            SqlCommand cmd_proveedor = new SqlCommand("dbo.SP_SAVE_PROVIDER", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_proveedor.CommandType = CommandType.StoredProcedure;
            cmd_proveedor.Parameters.Add(new SqlParameter("@razonSocial", proveedor.razonSocial));
            cmd_proveedor.Parameters.Add(new SqlParameter("@tel", proveedor.telefono));
            cmd_proveedor.Parameters.Add(new SqlParameter("@direc", proveedor.direccion.id));
            cmd_proveedor.Parameters.Add(new SqlParameter("@ciut", proveedor.cuit));
            cmd_proveedor.Parameters.Add(new SqlParameter("@rubro", proveedor.rubro));
            cmd_proveedor.Parameters.Add(new SqlParameter("@mail", proveedor.mail));
            cmd_proveedor.Parameters.Add(new SqlParameter("@contacto", proveedor.contacto));
            cmd_proveedor.Parameters.Add(new SqlParameter("@usuario", proveedor.usuario));
            
            cmd_proveedor.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }

        public bool esRazonSocialRepetido(int idProv, string razonSocial)
        {
            SqlCommand cmd = new SqlCommand(
                "select * from GESTION_BDD_2C_2019.PROVEEDOR WHERE RAZON_SOCIAL = @razonSocial AND id <> @prov_id", 
                ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();

            bool razonSocialRepetido = false;

            cmd.Parameters.Add("@razonSocial", SqlDbType.VarChar);
            cmd.Parameters.Add("@prov_id", SqlDbType.Int);
            cmd.Parameters["@razonSocial"].Value = razonSocial;
            cmd.Parameters["@prov_id"].Value = idProv;

            SqlDataReader r_proveedor = cmd.ExecuteReader();

            if (r_proveedor.Read())
            {
                razonSocialRepetido = true;
            }

            ConnectionQuery.cerrarConexion();

            return razonSocialRepetido;
        }

        public bool esCUITRepetido(int idProv, string cuit)
        {
            SqlCommand cmd = new SqlCommand(
                "SELECT * from GESTION_BDD_2C_2019.PROVEEDOR WHERE CUIT = @cuit AND id <> @prov_id ", 
                ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();

            bool cuitRepetido = false;

            cmd.Parameters.Add("@cuit", SqlDbType.VarChar);
            cmd.Parameters.Add("@prov_id", SqlDbType.Int);
            cmd.Parameters["@cuit"].Value = cuit;
            cmd.Parameters["@prov_id"].Value = idProv;
                
            SqlDataReader r_proveedor = cmd.ExecuteReader();

            if (r_proveedor.Read())
            {
                cuitRepetido = true;
            }

            ConnectionQuery.cerrarConexion();

            return cuitRepetido;
        }

    }
}