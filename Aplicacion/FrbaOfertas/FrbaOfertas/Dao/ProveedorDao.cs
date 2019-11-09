using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;
using FrbaOfertas.Repository;

namespace FrbaOfertas.Dao
{
    public class ProovedorDao : ProovedorRepository
    {
        public List<Proovedor> searchProovedores()
        {
            SqlCommand cmd_oferta = new SqlCommand("SELECT * FROM GESTION_BDD_2C_2019.OFERTA" , ConnectionQuery.Instance());
            ConnectionQuery.abrirConexion();
            SqlDataReader r_proovedor = cmd_oferta.ExecuteReader();
            List<Proovedor> proovedores = new List<Proovedor>();

            while (r_proovedor.Read())
            {
                Proovedor proovedor = new Proovedor();
                proovedor.id = Convert.ToInt32(r_proovedor["ID"]);
                proovedor.cuit = Convert.ToInt32(r_proovedor["CUIT"]);
                proovedor.razonSocial = Convert.ToString(r_proovedor["RAZON_SOCIAL"]);
                proovedor.mail = Convert.ToString(r_proovedor["MAIL"]);
                proovedor.telefono = Convert.ToInt32(r_proovedor["TELEFONO"]);
                proovedor.contacto = Convert.ToString(r_proovedor["CONTACTO"]);

                proovedores.Add(proovedor);
            }
            return proovedores;
        }
    }
}