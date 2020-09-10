using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class ShowCustomerBookings
    {
        public static void View(Customer newCustomer)
        {
            List<Booking> bookings = Read.UserBookings(newCustomer.CustomerId);

            Application.Init();
            var top = Application.Top;

            var win = new Window(new Rect(0, 0, top.Frame.Width, top.Frame.Height), "Show Customers");
            top.Add(win);

            var continueButton = new Button(1, 1, "Continue")
            {
                Clicked = () =>
                {
                    Application.RequestStop();
                }
            };

            win.Add(
                new Label(2, 3, "Booking"),
                new Label(12, 3, "Mail"),
                new Label(35, 3, "Movie Title"),
                new Label(80, 3, "Quantity"),
                new Label(95, 3, "Total Price"),
                continueButton
                );


            int y = 4;
            for (int i = 0; i < bookings.Count; i++)
            {
                Booking b = bookings[i];
                win.Add(
                    new Label(2, y, $"{b.BookingNumber}"),
                    new Label(12, y, $"{newCustomer.Mail}"),
                    new Label(35, y, $"{Read.SpecificMovie((int)b.MovieId).Title}"),
                    new Label(80, y, $"{b.Quantity}"),
                    new Label(95, y, $"{Read.SpecificMovie((int)b.MovieId).Price * b.Quantity:C0}")
                    );
                y++;
            }

            Application.Run();
        }
    }
}
