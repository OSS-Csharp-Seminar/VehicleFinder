using Microsoft.EntityFrameworkCore;
using VehicleFinder.Infrastructure;
using VehicleFinder.Entities;
using VehicleFinder.Infrastructure.Repositories;
using VehicleFinder.Services;
using VehicleFinder.Infrastructure.Repositories.Interfaces;
using VehicleFinder.Infrastructure.Repositories.Implementation;
using VehicleFinder.Services.Interface;
using VehicleFinder.Services.Implementation;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddDbContext<DatabaseContext>(o => o.UseNpgsql(builder.Configuration.GetConnectionString("VehicleFinderDB")));

builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<DatabaseContext>();
 

builder.Services.AddScoped<IListingRepository, ListingRepository>();
builder.Services.AddScoped<IListingService, ListingService>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<IVehicleService, VehicleService>();

builder.Services.AddScoped<IEngineRepository, EngineRepository>();
builder.Services.AddScoped<IEngineService, EngineService>();

builder.Services.AddScoped<IBodyRepository, BodyRepository>();
builder.Services.AddScoped<IBodyService, BodyService>();

var app = builder.Build();

// Configure the HTTP request pipeline.Q
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapControllers();

app.MapRazorPages();

app.Run();
