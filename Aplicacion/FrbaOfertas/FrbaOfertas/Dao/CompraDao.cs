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

        public void updateCompra(List<int> ofertasCompradasIds, int numeroFactura)
        {
            ofertasCompradasIds.ForEach(id => guardar(id, numeroFactura));
        }

        private void guardar(int id, int numeroFactura)
        {
            SqlCommand cmd_compra = new SqlCommand("dbo.SP_UPDATE_COMPRA", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_compra.Parameters.Add("@oferta_id", id);
            cmd_compra.Parameters.Add("@factura_id", numeroFactura);
            cmd_compra.CommandType = CommandType.StoredProcedure;
            cmd_compra.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
    }
}
