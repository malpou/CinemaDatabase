using System;
using System.Collections.Generic;

namespace CinemaDatabase.Models
{
    public partial class Movie
    {
        public Movie()
        {
            Booking = new HashSet<Booking>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Price { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
