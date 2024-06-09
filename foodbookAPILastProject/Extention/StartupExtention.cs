

using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace foodbookAPILastProject.Extention
{
    public static class StartupExtention
    {
        public static IServiceCollection addDb(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");
            service.AddDbContext<FoodbookContext>(options => options.UseSqlServer(ConnectionString));
            return service;

        }
    }
  
}
