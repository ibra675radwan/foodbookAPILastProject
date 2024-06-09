
using BLL.Mapping;
using BLL.Services.AuthenticationService;
using BLL.Services.Restaurants;
using BLL.Services.UserServices;
using DAL.Repositories._Genericrepositories;
using DAL.Repositories.restaurantRepositories;
using DAL.Repositories.UsersRepo;
using foodbookAPILastProject.Extention;
using Microsoft.Extensions.DependencyInjection.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//interfaces
builder.Services.addDb(builder.Configuration);
builder.Services.AddAutoMapperConfig();
builder.Services.AddRepositories();
builder.Services.AddServices();
builder.Services.AddControllerServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
