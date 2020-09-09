using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace CinemaDatabase.Controller
{
    class SQL
    {
        private static string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";

        public static bool CheckConnection()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
        }

        private static void CreateTable()
        {
            throw NotImplementedException;
        }
    }
}
