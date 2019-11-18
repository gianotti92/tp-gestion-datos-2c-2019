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
    public class CargarSaldoDao : CargarSalgoRepository
    {
        public void Save(CargaSaldo cargaSaldo)
        {
            SqlCommand cmd_carga_saldo = new SqlCommand("dbo.SP_SAVE_CARGA_SALDO", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            cmd_carga_saldo.CommandType = CommandType.StoredProcedure;

            cmd_carga_saldo.Parameters.Add("@cliente_id", cargaSaldo.idCliente);
            cmd_carga_saldo.Parameters.Add("@fecha", cargaSaldo.fecha);
            cmd_carga_saldo.Parameters.Add("@monto", cargaSaldo.monto);
            cmd_carga_saldo.Parameters.Add("@tipo", cargaSaldo.tipoPago.ToString());
            cmd_carga_saldo.Parameters.Add("@tarjeta_nro", cargaSaldo.numeroTarjeta);
            cmd_carga_saldo.Parameters.Add("@tarjeta_nombre", cargaSaldo.nombreTarjeta);
            cmd_carga_saldo.Parameters.Add("@tarjeta_fecha_vencimiento", cargaSaldo.fechaVencimientoTarjeta);
            cmd_carga_saldo.Parameters.Add("@tarjeta_codigo_seguridad", cargaSaldo.codigoSeguridadTarjeta);

            cmd_carga_saldo.ExecuteNonQuery();
            ConnectionQuery.cerrarConexion();
        }
    }
}
