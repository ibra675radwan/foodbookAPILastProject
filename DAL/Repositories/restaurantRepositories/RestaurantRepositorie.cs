using DAL.Models;
using DAL.Repositories._Genericrepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.restaurantRepositories
{
    public class RestaurantRepositorie : GenericRepositories<Restaurant>, iResturantRepositorie
    {
        public RestaurantRepositorie(FoodbookContext foodbookContext) : base(foodbookContext)
        {
        }
        public Restaurant GetRestaurantByName(string name)
        {
            var result = _dbSet.Where(x => x.Name == name).FirstOrDefault();
            return result;
        }
    }
}
