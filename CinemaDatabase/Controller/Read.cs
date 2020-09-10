using System.Collections.Generic;
using System.Linq;
using CinemaDatabase.Models;


namespace CinemaDatabase.Controller
{
    class Read
    {
        public static Customer SpecificCustomer(int userId)
        {
            using var context = new CinemaContext();
            return context.Customer.Single(c => c.CustomerId == userId);
        }
        public static Customer LastCustomer()
        {
            using var context = new CinemaContext();
            return context.Customer
                .OrderByDescending(c => c.CustomerId)
                .FirstOrDefault();
        }
        public static List<Customer> AllCustomers()
        {
            using var context = new CinemaContext();
            return context.Customer.ToList();
        }
        public static Movie SpecificMovie(int movieId)
        {
            using var context = new CinemaContext();
            return context.Movie.Single(m => m.MovieId == movieId);
        }
        public static List<Movie> AllMovies()
        {
            using var context = new CinemaContext();
            return context.Movie.ToList();
        }
        public static List<Booking> UserBookings(int userId)
        {
            using var context = new CinemaContext();
            return context.Booking.Where(b => b.CustomerId == userId).ToList();
        }
    }
}
