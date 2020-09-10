using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemaDatabase.Models;

namespace CinemaDatabase.Controller
{
    class Create
    {
        public static void Customer(string mail)
        {
            using var context = new CinemaContext();
            Customer customer = new Customer { Mail = mail };
            context.Customer.Add(customer);
            context.SaveChanges();
        }

        public static void Customer(string mail, string firstName)
        {
            using var context = new CinemaContext();
            Customer customer = new Customer
            {
                Mail = mail,
                FirstName = firstName
            };
            context.Customer.Add(customer);
            context.SaveChanges();
        } 
        public static void Customer(string mail, string firstName, string lastName)
        {
            using var context = new CinemaContext();
            Customer customer = new Customer
            {
                Mail = mail,
                FirstName = firstName,
                LastName = lastName
            };
            context.Customer.Add(customer);
            context.SaveChanges();
        }
        public static void Movie(string title, int price)
        {
            using CinemaContext context = new CinemaContext();
            Movie movie = new Movie
            {
                Title = title,
                Price = price
            };
            context.Movie.Add(movie);
            context.SaveChanges();
        }
        public static void Booking(int customerId, int movieId, int quantity) 
        {
            using CinemaContext context = new CinemaContext();
            Booking booking = new Booking
            {
                CustomerId = customerId,
                MovieId = movieId,
                BookingNumber = GetBookingNumber(),
                Quantity = quantity
            };
            context.Booking.Add(booking);
            context.SaveChanges();
        }

        private static int GetBookingNumber()
        {
            using var context = new CinemaContext();
            try
            {
                int maxBookingNumber = context.Booking.Max(b => b.BookingNumber);
                return maxBookingNumber + 1;
            }
            catch (InvalidOperationException) { return 1; }
        }
    }
}
