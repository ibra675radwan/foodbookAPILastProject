using BLL.Mapping;
namespace foodbookAPILastProject.Extention
{
    public static class autoMapperExtention
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service)
        {

            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new MappingProfiles());
            }, typeof(Program));
            return service;
        }




    }
}
