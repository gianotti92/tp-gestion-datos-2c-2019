using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Dao
{
    public class CiudadDao : CiudadRepository
    {
        public List<Ciudad> searchCiudadees()
        {
            SqlCommand cmd_ciudades = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.CIUDAD", ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            SqlDataReader reader = cmd_ciudades.ExecuteReader();
            List<Ciudad> ciudades = new List<Ciudad>();

            while (reader.Read())
            {
                Ciudad ciudad = new Ciudad();
                ciudad.id = Convert.ToInt32(reader["ID"]);
                ciudad.descripcion = Convert.ToString(reader["CIUDAD_NOMBRE"]);
                ciudades.Add(ciudad);
            }
            ConnectionQuery.cerrarConexion();
            return ciudades;
        }
    }
}