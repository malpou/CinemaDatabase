using System;
using CinemaDatabase.Controller;
using CinemaDatabase.Views;
using CinemaDatabase.Models;
using Terminal.Gui;


namespace CinemaDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            if (SQL.CheckConnection()) SQL.CreateDatabase();
            else Console.ReadKey();

            int homeChoice, typeChoice, usrActionChoice, admActionChoice;
            do
            {
                homeChoice = PickStart.View();
                if (homeChoice == 0)
                {
                    typeChoice = PickUserType.View();
                    if (typeChoice == 0)
                    {
                        Customer newCustomer = CreateCustomer.View();
                        ShowCustomer.View(newCustomer);
                        do
                        {
                            usrActionChoice = PickCustomerActions.View();
                            switch (usrActionChoice)
                            {
                                case 0:
                                    CreateBooking.View(newCustomer);
                                    break;
                                case 1:
                                    ShowCustomerBookings.View(newCustomer);
                                    break;
                                case 2:
                                    newCustomer = UpdateCustomer.View(newCustomer);
                                    break;
                                case 3:
                                    Delete.Customer(newCustomer.CustomerId);
                                    usrActionChoice = 4;
                                    break;
                                default:
                                    break;
                            }
                        } while (usrActionChoice != 4);
                    }
                    else if (typeChoice == 1)
                    {
                        do
                        {
                            admActionChoice = PickAdminActions.View();
                            switch (admActionChoice)
                            {
                                case 0:
                                    CreateMovie.View();
                                    break;
                                case 1:
                                    ShowCustomers.View();
                                    break;
                                default:
                                    break;
                            }
                        } while (admActionChoice != 2);
                    }
                }
            } while (homeChoice == 0);
        }
    }
}
