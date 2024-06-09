using Microsoft.AspNetCore.Mvc;
using BLL.DTO.Restaurant;
using BLL.Services.Restaurants;
using BLL.Wrapping;

namespace foodbookAPILastProject.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class restaurantController : _GenericController<RestaurantDTO>
    {
        private readonly IRestaurantService _restaurantService;

        public restaurantController(IRestaurantService genericservice) : base(genericservice)
        {
            _restaurantService = genericservice;
        }
        [HttpGet("GetAllRestaurants")]
        public APIResponse<IEnumerable<RestaurantDTO>> getAllRestaurants()
        {
            return _restaurantService.GetAll();
        }
        
       


    }
}