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
            context.Booking.RemoveRange(bookings);
            context.Customer.Remove(customer);
            context.SaveChanges();
        }
    }
    
}
