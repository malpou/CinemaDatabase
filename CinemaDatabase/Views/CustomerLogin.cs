using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using CinemaDatabase.Views;
using System.Collections.Generic;
using System.Linq;
using Terminal.Gui;

namespace CinemaDatabase
{
    class CustomerLogin
    {
        public static Customer View()
        {
            List<Customer> customers = Read.AllCustomers().OrderBy(c => c.Mail).ToList();
            Customer customer = new Customer();

            Application.Init();
            var top = Application.Top;

            var win = new Window(new Rect(0, 0, top.Frame.Width, top.Frame.Height), "Login To Existing Customer");
            top.Add(win);

            var customerIdField = new TextField(17, 2, 37, "");

            var loginBtn = new Button(5, 8, "Login")
            {
                Clicked = () =>
                {
                    if (Utilities.CheckCustomerId(customerIdField, out int customerId))
                    {

                        Application.RequestStop();
                        customer = Read.SpecificCustomer(customerId);
                    }
                    else
                    {
                        win.Add(new Label(3, 6, "Invalid Input..."));
                    }
                }
            };

            win.Add(
                new Label(3, 2, "Customer (ID): "),
                new Label(56, 2, "Customer (ID)"),
                new Label(68, 2, "Mail"),
                customerIdField,
                loginBtn
                ); ;

            int y = 3;
            for (int i = 0; i < customers.Count; i++)
            {
                Customer c = customers[i];
                win.Add(
                    new Label(56, y, $"{c.CustomerId}"),
                    new Label(68, y, $"{c.Mail}")
                    );
                y++;
            }
            Application.Run();
            return customer;
        }
    }
}