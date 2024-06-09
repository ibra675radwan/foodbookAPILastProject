using foodbookAPILastProject.Filters;

namespace foodbookAPILastProject.Extention
{
    public static class ControllerServices
    {
        public static IServiceCollection AddControllerServices(this IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(new GlobalExceptionFilter());
            });
            return services;
        }
    }
}
