using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class Utilities
    {
        public static bool IsValidEmail(TextField textField)
        {
            string email = FieldString(textField);
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }
        public static string CheckProp(string str)
        {
            return str != null ? str : "N/A";
        }
        public static bool FieldNotEmpty(TextField textField)
        {
            return FieldLength(textField) > 0;
        }
        public static bool FieldNotEmpty(TextField textField1, TextField textField2)
        {
            return FieldLength(textField1) > 0 && FieldLength(textField2) > 0;
        }
        public static string FieldString(TextField textField)
        {
            return textField.Text.ToString();
        }
        public static bool CheckMovieId(TextField textField, out int number)
        {

            if (int.TryParse(FieldString(textField), out int n))
            {
                number = n;
                List<Movie> movies = Read.AllMovies();
                foreach (Movie movie in movies)
                {
                    if (number == movie.MovieId)
                    {
                        return true;
                    }
                }
            }
            number = 0;
            return false;
        }
        public static bool CheckCustomerId(TextField textField, out int number)
        {

            if (int.TryParse(FieldString(textField), out int n))
            {
                number = n;
                List<Customer> customers = Read.AllCustomers();
                foreach (Customer customer in customers)
                {
                    if (number == customer.CustomerId)
                    {
                        return true;
                    }
                }
            }
            number = 0;
            return false;
        }
        public static bool CheckBookingNumber(TextField textField, Customer customer, out int number)
        {

            if (int.TryParse(FieldString(textField), out int n))
            {
                number = n;
                List<Booking> bookings = Read.UserBookings(customer.CustomerId);
                foreach (Booking booking in bookings)
                {
                    if (number == booking.BookingNumber)
                    {
                        return true;
                    }
                }
            }
            number = 0;
            return false;
        }
        private static int FieldLength(TextField textField)
        {
            string str = FieldString(textField);
            return str.Length;
        }
    }
}
