using CinemaDatabase.Controller;
using System;

namespace CinemaDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            if (SQL.CheckConnection())
            {
                SQL.CreateDatabase();
            }
            Create.Customer("mail4@test.com");
            Create.Customer("mail5@test.com", "Malthe");
            Create.Customer("mail6@test.com", "Henrik", "Poulsen");

        }
    }
}
