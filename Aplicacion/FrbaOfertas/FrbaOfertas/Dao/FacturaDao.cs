using System;
using System.Data;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Dao
{
    public class FacturaDao : FacturaRepository
    {
        public int save(Factura factura)
        {
            SqlCommand cmd_factura = new SqlCommand("dbo.SP_SAVE_FACTURA", ConnectionQuery.Instance());
            cmd_factura.CommandType = CommandType.StoredProcedure;
            ConnectionQuery.abrirConexion();
            cmd_factura.Parameters.Add("@fecha_inicio",factura.inicio);
            cmd_factura.Parameters.Add("@fecha_fin",factura.fin);
            cmd_factura.Parameters.Add("@fecha", factura.fechaFacturacion);
            cmd_factura.Parameters.Add("@prov_id",factura.proveedorId);
            int id = cmd_factura.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
            return id;
        }
    }
}