using System.Collections.Generic;
using System.Linq;
using CinemaDatabase.Models;


namespace CinemaDatabase.Controller
{
    class Read
    {
        public static List<Customer> AllCustomers()
        {
            using var context = new CinemaContext();
            return context.Customer.ToList();
        }
        public static Customer SpecificCustomer (int id)
        {
            using var context = new CinemaContext();
            return context.Customer.Single(c => c.CustomerId == id);
        }
        public static Movie SpecificMovie(int id)
        {
            using var context = new CinemaContext();
            return context.Movie.Single(m => m.MovieId == id);
        }
    }
}
