using System;
using System.Collections.Generic;
using System.Text;
using CinemaDatabase.Models;

namespace CinemaDatabase.Controller
{
    public class Create
    {
        public static void Customer(string mail)
        {
            using(var context = new CinemaContext())
            {
                Customer customer = new Customer { Mail = mail };
                context.Customer.Add(customer);
                context.SaveChanges();
            }
        }

        public static void Customer(string mail, string firstName)
        {
            using (var context = new CinemaContext())
            {
                Customer customer = new Customer { 
                    Mail = mail,
                    FirstName = firstName
                };
                context.Customer.Add(customer);
                context.SaveChanges();
            }
        } 
        public static void Customer(string mail, string firstName, string lastName)
        {
            using (var context = new CinemaContext())
            {
                Customer customer = new Customer { 
                    Mail = mail,
                    FirstName = firstName,
                    LastName = lastName
                };
                context.Customer.Add(customer);
                context.SaveChanges();
            }
        }
    }
}
