using System;
using System.Collections.Generic;

namespace CinemaDatabase.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int? CustomerId { get; set; }
        public int? MovieId { get; set; }
        public int BookingNumber { get; set; }
        public int Quantity { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
