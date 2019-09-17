using System.Data;
using System.Data.SqlClient;

namespace FrbaOfertas.Connection
{
    public class ConnectionQuery
    {
        private string ConnectionString = @"Data Source=DESKTOP-CIU60FJ\SQLSERVER2012;" +
                                          "Initial Catalog=GD2C2019;" +
                                          "Persist Security Info=True;" +
                                          "User ID=gdCupon2019;" +
                                          "Password=gd2019";
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