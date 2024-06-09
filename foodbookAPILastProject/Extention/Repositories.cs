using BLL.Services.Restaurants;
using BLL.Services.UserServices;
using DAL.Repositories.restaurantRepositories;
using DAL.Repositories.UsersRepo;

namespace foodbookAPILastProject.Extention
{
    public static class Repositories
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<IuserRepositoris, userRepositories>();
            service.AddScoped<iResturantRepositorie, RestaurantRepositorie>();
           
            return service;


        }
        public static IServiceCollection AddServices(this IServiceCollection service)
        {
            service.AddScoped<iUserService, UserService>();
            service.AddScoped<IRestaurantService, restaurantService>();
            return service;
        }
    }
}
