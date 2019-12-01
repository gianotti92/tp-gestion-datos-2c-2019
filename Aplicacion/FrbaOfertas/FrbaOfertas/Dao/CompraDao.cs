using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Dao
{
    public class CompraDao : CompraRepository
    {
        public int Save(Compra compra)
        {
            SqlCommand cmd_compra = new SqlCommand("dbo.SP_SAVE_COMPRA", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_compra.CommandType = CommandType.StoredProcedure;

            cmd_compra.Parameters.Add("@idOferta", compra.idOferta);
            cmd_compra.Parameters.Add("@idCliente", compra.idCliente);
            cmd_compra.Parameters.Add("@fecha", compra.fecha);

            int idCompra = Convert.ToInt32(cmd_compra.ExecuteScalar());
            ConnectionQuery.cerrarConexion();

            return idCompra;
        }

        public void updateCompra(int ofertasCompradasIds, DateTime fechaConsumo)
        {
            SqlCommand cmd_compra = new SqlCommand("dbo.SP_UPDATE_FECHA_CONSUMO", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_compra.Parameters.Add("@compra_id", ofertasCompradasIds);
            cmd_compra.Parameters.Add("@fecha_consumo", fechaConsumo);
            cmd_compra.CommandType = CommandType.StoredProcedure;
            cmd_compra.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }

        public void updateCompra(List<Compra> ofertasCompradasIds, int numeroFactura)
        {
            ofertasCompradasIds.ForEach(compra => guardar(compra.id, numeroFactura));
        }

        private void guardar(int id, int numeroFactura)
        {
            SqlCommand cmd_compra = new SqlCommand("dbo.SP_UPDATE_COMPRA", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_compra.Parameters.Add("@id_compra", id);
            cmd_compra.Parameters.Add("@factura_id", numeroFactura);
            cmd_compra.CommandType = CommandType.StoredProcedure;
            cmd_compra.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
        
         public Compra GetCompra(int idCompra)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.COMPRAS WHERE ID = @ID",
                ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();

            cmd.Parameters.Add("@ID", SqlDbType.VarChar);
            cmd.Parameters["@ID"].Value = idCompra;

            SqlDataReader r_compra = cmd.ExecuteReader();

            Compra compra = new Compra();

            if (r_compra.Read())
            {
                compra.id = Convert.ToInt32(r_compra["ID"]);
                compra.idOferta = Convert.ToInt32(r_compra["OFERTA_ID"]);
                compra.idCliente = Convert.ToInt32(r_compra["CLIENTE_ID"]);
                compra.fecha = Convert.ToDateTime(r_compra["FECHA"]);
                //compra.cupon = Convert.ToInt32(r_compra["CUPON"]);
                if (!(r_compra["FECHA_CONSUMO"] is DBNull))
                    compra.fechaConsumo = Convert.ToDateTime(r_compra["FECHA_CONSUMO"]);
                if (!(r_compra["FACTURA_ID"] is DBNull))
                    compra.idFactura = Convert.ToInt32(r_compra["FACTURA_ID"]);

            }

            ConnectionQuery.cerrarConexion();

            return compra;
        }


        public List<Compra> GetTodasCompras(){

            SqlCommand cmd = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.COMPRAS",
             ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();

            SqlDataReader r_compra = cmd.ExecuteReader();
            List<Compra> compras = new List<Compra>();

            while (r_compra.Read())
            {
                Compra compra = new Compra();
                compra.id = Convert.ToInt32(r_compra["ID"]);
                compra.idOferta = Convert.ToInt32(r_compra["OFERTA_ID"]);
                compra.idCliente = Convert.ToInt32(r_compra["CLIENTE_ID"]);
                compra.fecha = Convert.ToDateTime(r_compra["FECHA"]);

                if (!(r_compra["FECHA_CONSUMO"] is DBNull))
                {
                    compra.fechaConsumo = Convert.ToDateTime(r_compra["FECHA_CONSUMO"]);
                }

                if (!(r_compra["FACTURA_ID"] is DBNull))
                {
                    compra.idFactura = Convert.ToInt32(r_compra["FACTURA_ID"]);
                }
                
                compras.Add(compra);
            }

            ConnectionQuery.cerrarConexion();

            return compras;
        }

        public List<Compra> getComprasSinFactura(int provId, DateTime fechaInicio, DateTime fechaFin)
        {
            string fechaIni = fechaInicio.ToString("yyyy-MM-ddThh:mm:ss");
            string fechaFini = fechaFin.ToString("yyyy-MM-ddThh:mm:ss");
            SqlCommand cmd = new SqlCommand("select c.* from GESTION_BDD_2C_2019.COMPRAS c join GESTION_BDD_2C_2019.OFERTA o on c.OFERTA_ID = o.ID where o.PROV_ID = "+ provId +" and FACTURA_ID is null and FECHA BETWEEN " + "'"+fechaIni+"'" + " AND " + "'"+fechaFini + "'", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            
            SqlDataReader r_compra = cmd.ExecuteReader();
            List<Compra> compras = new List<Compra>();

            while (r_compra.Read())
            {
                if (!(r_compra["ID"] is DBNull))
                {
                    Compra compra = new Compra();
                    compra.id = Convert.ToInt32(r_compra["ID"]);
                    compra.idOferta = Convert.ToInt32(r_compra["OFERTA_ID"]);
                    compra.idCliente = Convert.ToInt32(r_compra["CLIENTE_ID"]);
                    compra.fecha = Convert.ToDateTime(r_compra["FECHA"]);
                    //compra.cupon = Convert.ToInt32(r_compra["CUPON"]);
                    if (!(r_compra["FECHA_CONSUMO"] is DBNull))
                        compra.fechaConsumo = Convert.ToDateTime(r_compra["FECHA_CONSUMO"]);
                    if (!(r_compra["FACTURA_ID"] is DBNull))
                        compra.idFactura = Convert.ToInt32(r_compra["FACTURA_ID"]);
                    compras.Add(compra);
                }
            }
            ConnectionQuery.cerrarConexion();
            return compras;
        }
    }
}
