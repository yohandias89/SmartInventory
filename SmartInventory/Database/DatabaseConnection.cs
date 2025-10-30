using Microsoft.Data.SqlClient;
using System.Configuration;


namespace SmartInventory.Database
{
    public static class DatabaseConnection
    {
        public static SqlConnection GetConnection() 
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            SqlConnection connection = new(connectionString);
            return connection;
        }
    }
}
