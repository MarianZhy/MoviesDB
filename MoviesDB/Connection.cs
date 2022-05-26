using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoviesDB
{
    class Connection
    {
        public static void GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "localhost";
            builder.UserID = "SA";
            builder.Password = "StrongPassword1";
            builder.InitialCatalog = "movies";
            builder.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            connection.Open();
            string Sql = "SELECT * FROM Movies";
            SqlCommand command = new SqlCommand(Sql, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(String.Format("{0}, {1}, {2}, {3}, {4}, {5}",
                    reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]));
            }

            connection.Close();
        }
       

    }
}

