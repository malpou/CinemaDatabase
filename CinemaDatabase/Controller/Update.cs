using CinemaDatabase.Models;
using System.Linq;

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
        public static void Booking(int id, int newMovieId, int newQuantity)
        {
            using var context = new CinemaContext();
            Booking booking = context.Booking.Single(b => b.BookingId == id);
            booking.MovieId = newMovieId;
            booking.Quantity = newQuantity;
            context.SaveChanges();
        }
    }
}
