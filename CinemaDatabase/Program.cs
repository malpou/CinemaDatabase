using System;
using CinemaDatabase.Controller;
using CinemaDatabase.Models;

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
        }
    }
}
