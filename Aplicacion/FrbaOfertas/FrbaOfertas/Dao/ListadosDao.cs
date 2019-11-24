using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Repository;
using FrbaOfertas.Entities;
using System.Data.SqlClient;
using System.Data;
using FrbaOfertas.Connection;

namespace FrbaOfertas.Dao
{
    public class ListadosDao : ListadosRepository
    {
        public List<ListadoTop5VendorFact> Top5Facturacion(Int32 anio, Int32 semestre)
        {
            List<ListadoTop5VendorFact> Proveedores = new List<ListadoTop5VendorFact>();
            SqlCommand consulta = new SqlCommand("dbo.SP_TOP5PROVMAYORFACTURACION", ConnectionQuery.Instance());
            consulta.CommandType = CommandType.StoredProcedure;
            ConnectionQuery.abrirConexion();
            consulta.Parameters.AddWithValue("@anio", anio);
            consulta.Parameters.AddWithValue("@semestre", semestre);
         
            SqlDataReader resultados = consulta.ExecuteReader();


            while (resultados.Read())
            {
                Proveedores.Add(new ListadoTop5VendorFact(resultados.GetDecimal(0), resultados.GetString(1), resultados.GetDecimal(2)));
            }
            

            ConnectionQuery.cerrarConexion();

            return Proveedores;
        }

        public List<ListadoTop5Descuento> Top5Descuento(Int32 anio, Int32 semestre)
        {
            List<ListadoTop5Descuento> Proveedores = new List<ListadoTop5Descuento>();
            SqlCommand consulta = new SqlCommand("dbo.SP_TOP5MAYORDESCUENTO", ConnectionQuery.Instance());
            consulta.CommandType = CommandType.StoredProcedure;
            ConnectionQuery.abrirConexion();
            consulta.Parameters.AddWithValue("@anio", anio);
            consulta.Parameters.AddWithValue("@semestre", semestre);

            SqlDataReader resultados = consulta.ExecuteReader();


            while (resultados.Read())
            {
                Proveedores.Add(new ListadoTop5Descuento(resultados.GetDecimal(0), resultados.GetString(1), resultados.GetDecimal(2)));
            }


            ConnectionQuery.cerrarConexion();

            return Proveedores;
        }
    }
}
