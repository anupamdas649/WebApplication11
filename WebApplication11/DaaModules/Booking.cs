using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication11.DaaModules
{
    public class Booking
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public long TotalCost { get; set; }
      

        public Customers Customers { get; set; }
        public Hotel Hotel { get; set; }
    }
}

