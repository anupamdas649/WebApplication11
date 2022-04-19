using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.DomainModels;
using WebApplication11.Repositories;

namespace WebApplication11.Controllers
{
    [ApiController]
    public class HotelController : Controller
    {
        private readonly IHotelsRepository hotelsRepository;
        private readonly IMapper mapper;

        public HotelController(IHotelsRepository hotelsRepository, IMapper mapper)
        {
            this.hotelsRepository = hotelsRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllHotels()
        {
            var hotels = await hotelsRepository.GetHotels();
            return Ok(mapper.Map<List<Hotel>>(hotels));
        }


        [HttpGet]
        [Route("[controller]/{ID:int}")]
        public async Task<IActionResult> GetHotel([FromRoute] int ID)
        {
            var hotel = await hotelsRepository.GetHotel(ID);

            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<Hotel>(hotel));
        }


    }
}