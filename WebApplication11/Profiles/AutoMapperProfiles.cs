using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.DomainModels;
using DaaModules =  WebApplication11.DaaModules;


namespace WebApplication11.Profiles
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DaaModules.Hotel, Hotel>().ReverseMap();

        }
    }
}
