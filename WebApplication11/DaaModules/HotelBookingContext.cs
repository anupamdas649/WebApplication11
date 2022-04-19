using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.DaaModules
{
    public class HotelBookingContext : DbContext
    {
        public HotelBookingContext()
        {
        }

        public HotelBookingContext(DbContextOptions<HotelBookingContext> options) : base(options) { }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Hotel> Hotel { get; set; }

    }


}
