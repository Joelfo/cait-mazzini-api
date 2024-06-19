using CaitMazziniApp.Database.Contexts;
using CaitMazziniApp.Models;
using CaitMazziniApp.Options;
using CaitMazziniApp.Options.Setup;
using CaitMazziniApp.ServiceCollectionExtensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

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

//Jwt configuration starts here
var jwtIssuer = builder.Configuration.GetSection("Jwt:Issuer").Get<string>();
var jwtKey = builder.Configuration.GetSection("Jwt:Key").Get<string>();
var jwtAudience = builder.Configuration.GetSection("Jwt:Audience").Get<string>();

builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer();

builder.Services.AddAuthorization();

builder.Services.ConfigureOptions<JwtOptionsSetup>();
builder.Services.ConfigureOptions<JwtBearerOptionsSetup>();
builder.Services.ConfigureOptions<SwaggerGenOptionsSetup>();
builder.Services.ConfigureOptions<AuthorizationOptionsSetup>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseDeveloperExceptionPage();

app.UseCors("AllOriginsAllowed");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
