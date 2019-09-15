using System;
using System.Data.SqlClient;
using FrbaOfertas.Connection;
using FrbaOfertas.Entities;

namespace FrbaOfertas.Repository
{
    public class LoginDao : LoginRepository
    {
        public Boolean validateLoginUser(PersonLogin personLogin)
        {
            ConnectionQuery query = new ConnectionQuery();
            query.OpenConection();
            SqlDataReader dr = query.DataReader("select * from GESTION_BDD_2C_2019.SIGNIN");
            dr.Read();
            String user = dr["username"].ToString();
            Console.WriteLine(user);
            query.CloseConnection();

            return true;
        }
    }
}
