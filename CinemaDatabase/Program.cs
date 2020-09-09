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
                Console.WriteLine("Forbindelse");
            }
        }
    }
}
