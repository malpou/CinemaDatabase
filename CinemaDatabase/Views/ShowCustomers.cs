using System.Collections.Generic;
using System.Linq;
using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using CinemaDatabase.Views;
using Terminal.Gui;

namespace CinemaDatabase
{
    class ShowCustomers
    {
        public static void View()
        {
            List<Customer> customers = Read.AllCustomers().OrderBy(c => c.Mail).ToList();

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
                new Label(2, 3, "ID"),
                new Label(10, 3, "Mail"),
                new Label(40, 3, "First Name"),
                new Label(65, 3, "Last Name"),
                new Label(17, 1, "--- Sorted alpfabetic by customer mail ---"),
                continueButton
                );
            

            int y = 4;
            for (int i = 0; i < customers.Count; i++)
            {
                Customer c = customers[i];
                win.Add(
                    new Label(2, y, $"{c.CustomerId}"),
                    new Label(10, y, $"{c.Mail}"),
                    new Label(40, y, $"{Utilities.CheckProp(c.FirstName)}"),
                    new Label(65, y, $"{Utilities.CheckProp(c.LastName)}")
                    );
                y++;
            }

            Application.Run();

        }
    }
}