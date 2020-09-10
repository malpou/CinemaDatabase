using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace CinemaDatabase.Controller
{
    class SQL
    {
        private static readonly string connectionString = "Server=.\\SQLEXPRESS;Database=master;Trusted_Connection=True;";

        public static bool CheckConnection()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
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

        public static void CreateDatabase()
        {
            RunQueryFile("BuildDB");
        }

        private static void RunQueryFile(string fileName)
        {
            FileInfo file = new FileInfo($"Querys/{fileName}.sql");
            string query = file.OpenText().ReadToEnd();
            string[] splitter = new string[] { "\r\nGO" };
            string[] commandTexts = query.Split(splitter, StringSplitOptions.RemoveEmptyEntries);

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            
            foreach (var commandText in commandTexts)
            {
                try
                {
                    using SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = commandText;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    connection.Close();
                    throw;
                }
            }
            connection.Close();
        }
    }
}
