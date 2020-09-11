using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using System.Collections.Generic;
using System.Linq;
using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class UdateBooking
    {
        public static void View(int customerId, int bookingNumber)
        {
            List<Movie> movies = Read.AllMovies();
            Booking booking = Read.UserBookings(customerId).Single(b => b.BookingNumber == bookingNumber);

            Application.Init();
            var top = Application.Top;

            var win = new Window(new Rect(0, 0, top.Frame.Width, top.Frame.Height), "Update Booking");
            top.Add(win);

            var movieIdField = new TextField(14, 2, 40, $"{booking.MovieId}");
            var quantityField = new TextField(14, 4, 40, $"{booking.Quantity}");

            var createBtn = new Button(5, 10, "Update Booking")
            {
                Clicked = () =>
                {
                    if (Utilities.CheckMovieId(movieIdField, out int movieId) && int.TryParse(Utilities.FieldString(quantityField), out int quantity))
                    {
                        Update.Booking(booking.BookingId, movieId, quantity);
                        Application.RequestStop();
                    }
                    else
                    {
                        win.Add(new Label(3, 8, "Invalid Input..."));
                    }
                }
            };

            win.Add(
                new Label(3, 2, "Movie (ID): "),
                new Label(3, 4, "Quantity: "),
                new Label(56, 2, "Movie (ID)"),
                new Label(68, 2, "Title"),
                new Label(110, 2, "Price"),
                movieIdField,
                quantityField,
                createBtn
                );

            int y = 3;
            for (int i = 0; i < movies.Count; i++)
            {
                Movie m = movies[i];
                win.Add(
                    new Label(56, y, $"{m.MovieId}"),
                    new Label(68, y, $"{m.Title}"),
                    new Label(110, y, $"{m.Price:C0}")
                    );
                y++;
            };
            Application.Run();
        }
    }
}