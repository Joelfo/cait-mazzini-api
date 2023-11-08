using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Models;
using CaitMazziniApp.ServiceCollectionExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Connect on databases
string connectionString = builder.Configuration.GetConnectionString("CaitMazziniDigitalChartConnection");

builder.Services.AddDbContext<CaitMazziniDbContext>(opts =>
    opts
        .UseLazyLoadingProxies()
        .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
);

// Add services to the container.
builder.Services.AddDependencyInjectionGroup();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddCors(options => options.AddPolicy(
    name: "AllOriginsAllowed",
    policy => policy.AllowAnyHeader().AllowAnyMethod().SetIsOriginAllowed(origin => true)
    )); ;

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseDeveloperExceptionPage();

app.UseAuthorization();

app.UseCors("AllOriginsAllowed");

app.MapControllers();

app.Run();
