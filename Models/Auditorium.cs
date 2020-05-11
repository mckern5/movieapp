using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviebooking.Models
{
    public class Auditorium
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string Address { get; set; }
        public virtual IList<Seat> Seats { get; set; }
        public int TotalSeats => this.Seats == null ? 0 : this.Seats.Count;
    }
}
