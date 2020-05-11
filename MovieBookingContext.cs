using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moviebooking.Models;

namespace Moviebooking
{
    public class MovieBookingContext:DbContext
    {
        public DbSet<Auditorium> Auditoriums { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        public MovieBookingContext(DbContextOptions<MovieBookingContext> options):base(options)
        {

        }

    }
}
