using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using System.Collections.Generic;
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

            var bookingNumberField = new TextField(20, 1, 17, "");
            var continueButton = new Button(1, 1, "Continue")
            {
                Clicked = () =>
                {
                    Application.RequestStop();
                }
            };
            var editButton = new Button(45, 1, "Edit Booking")
            {
                Clicked = () =>
                {
                    if (Utilities.CheckBookingNumber(bookingNumberField, newCustomer, out int bookingNumber))
                    {

                        Application.RequestStop();
                        UdateBooking.View(newCustomer.CustomerId, bookingNumber);
                    }
                    else
                    {
                        win.Add(new Label(20, 3, "Invalid input..."));
                    }
                }
            };

            win.Add(
                new Label(20, 0, "Booking (Number)"),
                new Label(2, 3, "Booking"),
                new Label(12, 3, "Mail"),
                new Label(35, 3, "Movie Title"),
                new Label(80, 3, "Quantity"),
                new Label(95, 3, "Total Price"),
                bookingNumberField,
                editButton,
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
            };
            Application.Run();
        }
    }
}
