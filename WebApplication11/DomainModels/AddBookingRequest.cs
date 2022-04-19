using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.DaaModules;

namespace WebApplication11.DomainModels
{
    public class AddBookingRequest
    {
        public String CheckInDate { get; set; }
        public String CheckOutDate { get; set; }
        public int TotalDays { get; set; }
        public long TotalCost { get; set; }


        public Customers Customers { get; set; }
        public Hotel Hotel { get; set; }
    }
}
