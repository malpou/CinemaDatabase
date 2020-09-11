using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using CinemaDatabase.Views;


namespace CinemaDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            if (SQL.CheckConnection()) SQL.CreateDatabase();

            int homeChoice, typeChoice, usrActionChoice, admActionChoice, newOldChoice;
            Customer customer;
            do
            {
                homeChoice = PickStart.View();
                if (homeChoice == 0)
                {
                    typeChoice = PickUserType.View();
                    if (typeChoice == 0)
                    {
                        newOldChoice = PickNewOrOldCustomer.View();
                        if (newOldChoice == 0)
                        {
                            customer = CustomerLogin.View();
                        }
                        else
                        {
                            customer = CreateCustomer.View();
                        }
                        ShowCustomer.View(customer);
                        do
                        {
                            usrActionChoice = PickCustomerActions.View();
                            switch (usrActionChoice)
                            {
                                case 0:
                                    CreateBooking.View(customer);
                                    break;
                                case 1:
                                    ShowCustomerBookings.View(customer);
                                    break;
                                case 2:
                                    customer = UpdateCustomer.View(customer);
                                    break;
                                case 3:
                                    Delete.Customer(customer.CustomerId);
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
