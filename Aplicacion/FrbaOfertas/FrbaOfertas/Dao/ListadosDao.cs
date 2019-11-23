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
        public List<ListadoTop5VendorFact> top5Facturacion(Int32 anio, Int32 semestre)
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
                Proveedores.Add(new ListadoTop5VendorFact(resultados.GetInt32(0), resultados.GetString(1), resultados.GetDouble(2)));
            }
            

            ConnectionQuery.cerrarConexion();

            return Proveedores;
        }
    }
}
