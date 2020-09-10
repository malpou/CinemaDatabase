using CinemaDatabase.Models;
using System.Collections.Generic;
using System.Linq;

namespace CinemaDatabase.Controller
{
    class Delete
    {
        public static void Customer(int customerId)
        {
            using CinemaContext context = new CinemaContext();
            Customer customer = Read.SpecificCustomer(customerId);
            List<Booking> bookings = Read.UserBookings(customerId);
            foreach (Booking booking in bookings)
            {
                Booking(customerId);
            }
            context.Customer.Remove(customer);
            context.SaveChanges();
        }

        private static void Booking(int bookingId)
        {
            using var context = new CinemaContext();
            var booking = context.Booking.Single(b => b.BookingId == bookingId);
            context.Booking.Remove(booking);
            context.SaveChanges();
        }
    }
    
}
