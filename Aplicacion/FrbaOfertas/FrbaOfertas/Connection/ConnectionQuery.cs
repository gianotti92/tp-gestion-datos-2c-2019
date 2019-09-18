using System.Data;
using System.Data.SqlClient;

namespace FrbaOfertas.Connection
{
    public class ConnectionQuery
    {
        string ConnectionString = "";  
        SqlConnection con;  
  
        public void OpenConection()  
        {  
            con = new SqlConnection(ConnectionString);  
            con.Open();  
        }  
  
  
        public void CloseConnection()  
        {  
            con.Close();  
        }  
  
  
        public void ExecuteQueries(string Query_)  
        {  
            SqlCommand cmd = new SqlCommand(Query_,con);  
            cmd.ExecuteNonQuery();  
        }  
  
  
        public SqlDataReader DataReader(string Query_)  
        {  
            SqlCommand cmd = new SqlCommand(Query_,con);  
            SqlDataReader dr = cmd.ExecuteReader();  
            return dr;  
        }  
  
  
        public object ShowDataInGridView(string Query_)  
        {  
            SqlDataAdapter dr = new SqlDataAdapter(Query_, ConnectionString);  
            DataSet ds = new DataSet();  
            dr.Fill(ds);  
            object dataum = ds.Tables[0];  
            return dataum;  
        }  
    }
}