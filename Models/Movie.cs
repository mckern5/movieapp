using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviebooking.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set }
        public string Poster { get; set }
        public string Description { get;set }
        public string Cast { get; set }
        public string Director { get; set }
        public string Genre { get;set }
    }
}
