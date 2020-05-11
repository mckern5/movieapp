using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviebooking.Models
{
    public class Ticket
    {

        public Ticket()
        {
            this.SeatIds = new List<int>();
        }

        public int ShowId { get; set; }
        public List<int> SeatIds { get; set; }
        public int Quantity => this.SeatIds == null ? 0 : this.SeatIds.Count;

    }
}
