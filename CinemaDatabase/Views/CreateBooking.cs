using System.Collections.Generic;
using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class CreateBooking
    {
        public static void View(Models.Customer customer)
        {
            List<Movie> movies = Read.AllMovies();

            Application.Init();
            var top = Application.Top;

            var win = new Window(new Rect(0, 0, top.Frame.Width, top.Frame.Height), "Create Customer");
            top.Add(win);

            var movieIdField = new TextField(14, 2, 40, "");
            var quantityField = new TextField(14, 4, 40, "");
            
            var createBtn = new Button(5, 10, "Create New Booking")
            {
                Clicked = () =>
                {
                    if (Utilities.CheckId(movieIdField, out int movieId) && int.TryParse(Utilities.FieldString(quantityField), out int quantity))
                    {
                        Create.Booking(customer.CustomerId, movieId, quantity);
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
            }

            Application.Run();
        }
    }
}
