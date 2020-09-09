using CinemaDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CinemaDatabase.Controller
{
    class Update
    {
        public static void SpecificCustomer(int id, string mail)
        {
            using var context = new CinemaContext();
            Customer customer = context.Customer.Single(c => c.CustomerId == id);
            customer.Mail = mail;
            context.SaveChanges();
        }
    }
}
