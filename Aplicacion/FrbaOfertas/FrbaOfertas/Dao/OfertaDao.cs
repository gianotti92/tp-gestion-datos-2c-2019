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
                oferta.id = Convert.ToString(r_rol["ID"]);
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

        public List<Oferta> searchOfertas(string descripcion, int provId)
        {
            StringBuilder builder = new StringBuilder("SELECT * FROM GESTION_BDD_2C_2019.OFERTA WHERE ");

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


            SqlCommand cmd_oferta = new SqlCommand("" , ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            SqlDataReader r_rol = cmd_oferta.ExecuteReader();
            List<Oferta> ofertas = new List<Oferta>();

            while (r_rol.Read())
            {
                Oferta oferta = new Oferta();
                oferta.id = Convert.ToString(r_rol["ID"]);
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
            
            int idOferta = Convert.ToInt32(cmd_oferta.ExecuteScalar());
            
            cmd_oferta.Parameters.Add("@Id", idOferta);
            cmd_oferta.Parameters.Add("@proovedor_id", oferta.proovedorId);
            cmd_oferta.Parameters.Add("@precio", oferta.precio);
            cmd_oferta.Parameters.Add("@precioLista", oferta.precioLista);
            cmd_oferta.Parameters.Add("@stockDisponible", oferta.stockDisponible);
            cmd_oferta.Parameters.Add("@fechaPublicacion", oferta.fechaPublicacion);
            cmd_oferta.Parameters.Add("@fechaVencimiento", oferta.fechaVencimiento);
            cmd_oferta.Parameters.Add("@cantidadMaximaPorCompra", oferta.cantidadMaximaPorCompra);
            cmd_oferta.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
    }
}