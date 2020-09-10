using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using CinemaDatabase.Views;
using Terminal.Gui;

namespace CinemaDatabase
{
    class UpdateCustomer
    {
        public static Customer View(Customer newCustomer)
        {
            Application.Init();
            var top = Application.Top;

            var win = new Window(new Rect(0, 0, top.Frame.Width, top.Frame.Height), "Create Customer");
            top.Add(win);

            var mailField = new TextField(14, 2, 40, $"{newCustomer.Mail}");
            var firstNameField = new TextField(14, 4, 40, $"{newCustomer.FirstName}");
            var lastNameField = new TextField(14, 6, 40, $"{newCustomer.LastName}");
            var createBtn = new Button(5, 10, "Edit Customer")
            {
                Clicked = () =>
                {
                    if (Utilities.IsValidEmail(mailField))
                    {
                        Update.Customer(
                            newCustomer.CustomerId,
                            Utilities.FieldString(mailField),
                            Utilities.FieldString(firstNameField),
                            Utilities.FieldString(lastNameField)
                            );
                        Application.RequestStop();
                    }
                    else
                    {
                        win.Add(new Label(3, 8, "Invalid Input..."));
                    }
                }
            };

            win.Add(
                new Label(3, 2, "Mail: "),
                new Label(3, 4, "First Name: "),
                new Label(3, 6, "Last Name: "),
                mailField,
                firstNameField,
                lastNameField,
                createBtn);

            Application.Run();
            return Read.SpecificCustomer(newCustomer.CustomerId);
        }
    }
}