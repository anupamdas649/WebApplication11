using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.DaaModules;

namespace WebApplication11.Repositories
{
    public interface IHotelsRepository
    {
        Task<List<Hotel>> GetHotels();
        Task<Hotel> GetHotel(int ID);
        Task GetCustomers(int customers);
        //Task<Booking> AddBookingRequest();
    }
}
