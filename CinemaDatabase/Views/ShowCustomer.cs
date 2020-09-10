using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class ShowCustomer
    {
        public static void View(Models.Customer customer)
        {
            Application.Init();
            var top = Application.Top;

            var win = new Window(new Rect(0, 0, top.Frame.Width, top.Frame.Height), "Customer Information");
            top.Add(win);

            var continueButton = new Button(4, 8, "Continue")
            {
                Clicked = () =>
                {
                    Application.RequestStop();
                }
            };

            win.Add(
                new Label(3, 2, $"Mail:  {customer.Mail}"),
                new Label(3, 4, $"First Name:  {Utilities.CheckProp(customer.FirstName)}"),
                new Label(3, 6, $"Last Name:  {Utilities.CheckProp(customer.LastName)}"),
                continueButton
                );
                


            Application.Run();
        }

        
    }
}
