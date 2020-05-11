using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Moviebooking.Models
{
    public class Booking
    {

        public Booking()
        {
            this.Tickets = new List<Ticket>();

        }

        public int ID { get; set; }
        public IList<Ticket> Tickets { get; set; }
    }
}
