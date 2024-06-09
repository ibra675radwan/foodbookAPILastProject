using BLL.DTO.Restaurant;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Services.GenericServices;
using DAL.Repositories._Genericrepositories;
using AutoMapper;
using DAL.Repositories;
using BLL.Wrapping;
using DAL.Models;
using DAL.Repositories.restaurantRepositories;

namespace BLL.Services.Restaurants
{
    public class restaurantService : GenericServices< Restaurant , RestaurantDTO>, IRestaurantService
    {
        private readonly IMapper _mapper;
        private readonly iResturantRepositorie _restaurantRepositories;
        public restaurantService(iResturantRepositorie restaurantRepository, IMapper mapper) : base(restaurantRepository, mapper)
        {
            _restaurantRepositories = restaurantRepository;
            _mapper = mapper;
        }
        public APIResponse<RestaurantDTO> GetRestaurantByName(string name)
        {
            var response = new APIResponse<RestaurantDTO>();
            var result = _restaurantRepositories.GetRestaurantByName(name);
            response.Data = _mapper.Map<RestaurantDTO>(result);
            return response;
        }
        

    }
}
