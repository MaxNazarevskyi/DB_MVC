using MySql.Data.MySqlClient;

namespace ProductsMarket.DataAccess
{
    public class DBConnection
    {
        public string GetConnectionString()
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "127.0.0.1",
                Database = "Labs",
                UserID = "root",
                Password = ""
            };

            return builder.ConnectionString;
        }
    }
}
