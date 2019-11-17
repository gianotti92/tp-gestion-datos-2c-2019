using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Dao
{
    public class OfertaDao : OfertaRepository
    {
        public List<Oferta> searchOfertas()
        {
            SqlCommand cmd_oferta = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.OFERTA" , ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            SqlDataReader r_rol = cmd_oferta.ExecuteReader();
            List<Oferta> ofertas = new List<Oferta>();

            while (r_rol.Read())
            {
                Oferta oferta = new Oferta();
                oferta.id = Convert.ToInt32(r_rol["ID"]);
                oferta.idold = Convert.ToString(r_rol["IDold"]);
                oferta.proovedorId = Convert.ToInt32(r_rol["PROV_ID"]);
                oferta.precio = Convert.ToInt64(r_rol["PRECIO"]);
                oferta.precioLista = Convert.ToInt64(r_rol["PRECIO_LISTO"]);
                oferta.stockDisponible = Convert.ToInt32(r_rol["STOCK_DISPONIBLE"]);
                oferta.fechaPublicacion = (DateTime) r_rol["FECHA_PUBLIC"];
                oferta.fechaVencimiento = (DateTime) r_rol["FECHA_VENC"];
                oferta.cantidadMaximaPorCompra = Convert.ToInt32(r_rol["MAX_X_COMPRA"]);
                ofertas.Add(oferta);
            }
            ConnectionQuery.cerrarConexion();
            return ofertas;
        }

        public List<Oferta> searchOfertasVigentes(string descripcion, int provId)
        {
            string fechaDia = System.Configuration.ConfigurationManager.AppSettings.Get("fecha_dia");
            
            StringBuilder builder =
                new StringBuilder("SELECT * FROM GESTION_BDD_2C_2019.OFERTA WHERE FECHA_VENC > '" +fechaDia + "' AND ");

            if (!string.IsNullOrEmpty(descripcion) && provId == 0)
            {
                builder.Append("DESCRIPCION LIKE '%" + descripcion + "%'");
            }

            if (string.IsNullOrEmpty(descripcion) && provId > 0)
            {
                builder.Append("PROV_ID = " + provId);
            }

            if (!string.IsNullOrEmpty(descripcion) && provId > 0)
            {
                builder.Append("DESCRIPCION LIKE '%" + descripcion + "%' AND PROV_ID = " + provId);
            }


            SqlCommand cmd_oferta = new SqlCommand(builder.ToString() , ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            SqlDataReader r_rol = cmd_oferta.ExecuteReader();
            List<Oferta> ofertas = new List<Oferta>();

            while (r_rol.Read())
            {
                Oferta oferta = new Oferta();
                oferta.id = Convert.ToInt32(r_rol["ID"]);
                oferta.idold = Convert.ToString(r_rol["IDold"]);
                oferta.proovedorId = Convert.ToInt32(r_rol["PROV_ID"]);
                oferta.precio = Convert.ToInt64(r_rol["PRECIO"]);
                oferta.precioLista = Convert.ToInt64(r_rol["PRECIO_LISTO"]);
                oferta.stockDisponible = Convert.ToInt32(r_rol["STOCK_DISPONIBLE"]);
                oferta.fechaPublicacion = (DateTime) r_rol["FECHA_PUBLIC"];
                oferta.fechaVencimiento = (DateTime) r_rol["FECHA_VENC"];
                oferta.cantidadMaximaPorCompra = Convert.ToInt32(r_rol["MAX_X_COMPRA"]);
                ofertas.Add(oferta);
            }
            ConnectionQuery.cerrarConexion();
            return ofertas;
        }

        public List<Oferta> searchOfertasVigentes()
        {
            string fechaDia = System.Configuration.ConfigurationManager.AppSettings.Get("fecha_dia");
            
            StringBuilder builder = new StringBuilder("SELECT * FROM GESTION_BDD_2C_2019.OFERTA WHERE FECHA_VENC > '" +fechaDia + "'");
            
            SqlCommand cmd_oferta = new SqlCommand(builder.ToString() , ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            SqlDataReader r_rol = cmd_oferta.ExecuteReader();
            List<Oferta> ofertas = new List<Oferta>();

            while (r_rol.Read())
            {
                Oferta oferta = new Oferta();
                oferta.id = Convert.ToInt32(r_rol["ID"]);
                oferta.idold = Convert.ToString(r_rol["IDold"]);
                oferta.proovedorId = Convert.ToInt32(r_rol["PROV_ID"]);
                oferta.precio = Convert.ToInt64(r_rol["PRECIO"]);
                oferta.precioLista = Convert.ToInt64(r_rol["PRECIO_LISTO"]);
                oferta.stockDisponible = Convert.ToInt32(r_rol["STOCK_DISPONIBLE"]);
                oferta.fechaPublicacion = (DateTime) r_rol["FECHA_PUBLIC"];
                oferta.fechaVencimiento = (DateTime) r_rol["FECHA_VENC"];
                oferta.cantidadMaximaPorCompra = Convert.ToInt32(r_rol["MAX_X_COMPRA"]);
                ofertas.Add(oferta);
            }
            ConnectionQuery.cerrarConexion();
            return ofertas;
        }

        public void saveOferta(Oferta oferta)
        {
            SqlCommand cmd_oferta = new SqlCommand("dbo.SP_SAVE_OFERTA", ConnectionQuery.Instance());
            cmd_oferta.CommandType = CommandType.StoredProcedure;
            ConnectionQuery.abrirConexion();
            
            
            //cmd_oferta.Parameters.Add("@Id", idOferta);
            cmd_oferta.Parameters.Add("@proovedor_id", oferta.proovedorId);
            cmd_oferta.Parameters.Add("@precio", oferta.precio);
            cmd_oferta.Parameters.Add("@precioLista", oferta.precioLista);
            cmd_oferta.Parameters.Add("@stockDisponible", oferta.stockDisponible);
            cmd_oferta.Parameters.Add("@fechaPublicacion", oferta.fechaPublicacion);
            cmd_oferta.Parameters.Add("@fechaVencimiento", oferta.fechaVencimiento);
            cmd_oferta.Parameters.Add("@cantidadMaximaPorCompra", oferta.cantidadMaximaPorCompra);
            oferta.id = Convert.ToInt32(cmd_oferta.ExecuteScalar());
            cmd_oferta.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }

        public List<Oferta> searchOfertasByProveedor(int proveedorId)
        {
            SqlCommand cmd_oferta = new SqlCommand("dbo.SP_GET_OFERTAS_BY_PROVIDER", ConnectionQuery.Instance());
            cmd_oferta.CommandType = CommandType.StoredProcedure;
            ConnectionQuery.abrirConexion();
            cmd_oferta.Parameters.Add("@id_proveedor",proveedorId);
            
            SqlDataReader r_oferta = cmd_oferta.ExecuteReader();
            List<Oferta> ofertas = new List<Oferta>();

            while (r_oferta.Read())
            {
                Oferta oferta = new Oferta();
                oferta.id = Convert.ToInt32(r_oferta["ID"]);
                oferta.idold = Convert.ToString(r_oferta["IDold"]);
                oferta.proovedorId = Convert.ToInt32(r_oferta["PROV_ID"]);
                oferta.precio = Convert.ToInt64(r_oferta["PRECIO"]);
                oferta.precioLista = Convert.ToInt64(r_oferta["PRECIO_LISTO"]);
                oferta.stockDisponible = Convert.ToInt32(r_oferta["STOCK_DISPONIBLE"]);
                oferta.fechaPublicacion = (DateTime) r_oferta["FECHA_PUBLIC"];
                oferta.fechaVencimiento = (DateTime) r_oferta["FECHA_VENC"];
                oferta.cantidadMaximaPorCompra = Convert.ToInt32(r_oferta["MAX_X_COMPRA"]);
                ofertas.Add(oferta);
            }
            ConnectionQuery.cerrarConexion();
            return ofertas;
        }

        public List<int> searchAnios()
        {
            SqlCommand cmd_anio = new SqlCommand("select year(FECHA_PUBLIC) as fecha from GESTION_BDD_2C_2019.OFERTA group by year(FECHA_PUBLIC)", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            SqlDataReader r_rol = cmd_anio.ExecuteReader();
            List<int> ofertas = new List<int>();
            while (r_rol.Read())
            {
                ofertas.Add(Convert.ToInt16(r_rol["fecha"]));
            }
            ConnectionQuery.cerrarConexion();
            return ofertas;
        }

        public List<Oferta> searchOfertasAdquiridasByProveedor(int proveedorId, DateTime fechaInicio, DateTime fechaFin)
        {
            SqlCommand cmd_oferta = new SqlCommand("dbo.SP_GET_OFERTAS_ADQUIRIDAS_BY_PROVIDER", ConnectionQuery.Instance());
            cmd_oferta.CommandType = CommandType.StoredProcedure;
            ConnectionQuery.abrirConexion();
            cmd_oferta.Parameters.Add("@id_proveedor", proveedorId);
            cmd_oferta.Parameters.Add("@fecha_inicio", fechaInicio);
            cmd_oferta.Parameters.Add("@fecha_fin", fechaFin);

            SqlDataReader r_oferta = cmd_oferta.ExecuteReader();
            List<Oferta> ofertas = new List<Oferta>();

            while (r_oferta.Read())
            {
                Oferta oferta = new Oferta();
                oferta.id = Convert.ToInt32(r_oferta["ID"]);
                oferta.idold = Convert.ToString(r_oferta["IDold"]);
                oferta.proovedorId = Convert.ToInt32(r_oferta["PROV_ID"]);
                oferta.precio = Convert.ToInt64(r_oferta["PRECIO"]);
                oferta.precioLista = Convert.ToInt64(r_oferta["PRECIO_LISTO"]);
                oferta.stockDisponible = Convert.ToInt32(r_oferta["STOCK_DISPONIBLE"]);
                oferta.fechaPublicacion = (DateTime)r_oferta["FECHA_PUBLIC"];
                oferta.fechaVencimiento = (DateTime)r_oferta["FECHA_VENC"];
                oferta.cantidadMaximaPorCompra = Convert.ToInt32(r_oferta["MAX_X_COMPRA"]);
                ofertas.Add(oferta);
            }
            ConnectionQuery.cerrarConexion();
            return ofertas;
        }
    }
}