using System;
using System.Collections.Generic;

namespace CinemaDatabase.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Booking = new HashSet<Booking>();
        }

        public int CustomerId { get; set; }
        public string Mail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
