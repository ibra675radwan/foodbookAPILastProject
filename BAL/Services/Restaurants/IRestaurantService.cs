using BLL.DTO.Restaurant;
using BLL.Services.GenericServices;
using BLL.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Restaurants
{
    public interface IRestaurantService : iGenericServices<RestaurantDTO>
    {
        APIResponse<RestaurantDTO> GetRestaurantByName(string name);
        
    }
}
