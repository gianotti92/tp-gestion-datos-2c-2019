using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Dao
{
    public class RubroDao : RubroRepository
    {
        public List<Rubro> searchRubros()
        {
            SqlCommand cmd_rubro = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.RUBRO", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            SqlDataReader reader = cmd_rubro.ExecuteReader();
            List<Rubro> rubros = new List<Rubro>();

            while (reader.Read())
            {
                Rubro rubro = new Rubro();
                rubro.id = Convert.ToInt32(reader["ID"]);
                rubro.description = Convert.ToString(reader["DESCRIPCION"]);
                rubros.Add(rubro);
            }
            ConnectionQuery.cerrarConexion();
            return rubros;
        }
    }
}