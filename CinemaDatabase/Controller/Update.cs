using System.Linq;
using CinemaDatabase.Models;

namespace CinemaDatabase.Controller
{
    class Update
    {
        public static void Customer(int id, string newMail, string newFirstName, string newLastName)
        {
            using var context = new CinemaContext();
            Customer customer = context.Customer.Single(c => c.CustomerId == id);
            customer.Mail = newMail;
            customer.FirstName = newFirstName == "" ? null : newFirstName;
            customer.LastName = newLastName == "" ? null : newFirstName;
            context.SaveChanges();
        }
        public static void Movie(int id, string newTitle)
        {
            using var context = new CinemaContext();
            Movie movie = context.Movie.Single(m => m.MovieId == id);
            movie.Title = newTitle;
            context.SaveChanges();
        }
        public static void Movie(int id, int newPrice)
        {
            using var context = new CinemaContext();
            Movie movie = context.Movie.Single(m => m.MovieId == id);
            movie.Price = newPrice;
            context.SaveChanges();
        }
        public static void Movie(int id, string newTitle, int newPrice)
        {
            using var context = new CinemaContext();
            Movie movie = context.Movie.Single(m => m.MovieId == id);
            movie.Title = newTitle;
            movie.Price = newPrice;
            context.SaveChanges();
        }
        public static void BookingMovie(int id, int newMovieId)
        {
            using var context = new CinemaContext();
            Booking booking = context.Booking.Single(b => b.BookingId == id);
            booking.MovieId = newMovieId;
            context.SaveChanges();
        }
        public static void BookingQuantity(int id, int newQuantity)
        {
            using var context = new CinemaContext();
            Booking booking = context.Booking.Single(b => b.BookingId == id);
            booking.Quantity = newQuantity;
            context.SaveChanges();
        }
    }
}
