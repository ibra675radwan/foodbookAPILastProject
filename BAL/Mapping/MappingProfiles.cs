using AutoMapper;
using BLL.DTO.User;
using BLL.DTO.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace BLL.Mapping
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles() 
        { 
        CreateMap<User , UserDto>().ReverseMap();
            CreateMap<Restaurant , RestaurantDTO>().ReverseMap();


        }
    }
}
