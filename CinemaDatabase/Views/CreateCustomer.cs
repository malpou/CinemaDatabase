using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Gui;
using CinemaDatabase.Controller;

namespace CinemaDatabase.Views
{
    class CreateCustomer
    {
        public static Models.Customer View()
        {
            Application.Init();
            var top = Application.Top;

            var win = new Window(new Rect(0, 0, top.Frame.Width, top.Frame.Height), "Create Customer");
            top.Add(win);

            var mailField = new TextField(14, 2, 40, "");
            var firstNameField = new TextField(14, 4, 40, "");
            var lastNameField = new TextField(14, 6, 40, "");
            var createBtn = new Button(5, 10, "Create New Customer")
            {
                Clicked = () =>
                {
                    if (Utilities.IsValidEmail(mailField))
                    {
                        if (Utilities.FieldNotEmpty(firstNameField, lastNameField))
                        {
                            Create.Customer(
                                Utilities.FieldString(mailField),
                                Utilities.FieldString(firstNameField),
                                Utilities.FieldString(lastNameField)
                                );
                        }
                        else if (Utilities.FieldNotEmpty(firstNameField))
                        {
                            Create.Customer(
                                Utilities.FieldString(mailField),
                                Utilities.FieldString(firstNameField)
                                );
                        }
                        else
                        {
                            Create.Customer(Utilities.FieldString(mailField));
                        }
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
            return Read.LastCustomer();
        }
    }
}
