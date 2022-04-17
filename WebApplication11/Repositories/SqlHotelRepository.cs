using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.DaaModules;

namespace WebApplication11.Repositories
{
    public class SqlHotelRepository : IHotelsRepository
    {
        private readonly HotelBookingContext context;
        public SqlHotelRepository(HotelBookingContext context)
        {
            this.context = context;
        }

    

        //public HotelBookingContext Context { get; }

        public async Task<List<Hotel>> GetHotels()
        {
            return await context.Hotel.ToListAsync();
        }

        public async Task<Hotel> GetHotel(int ID)
        {
            return await context.Hotel.FirstOrDefaultAsync(x => x.ID == ID);
        }


    }
}
