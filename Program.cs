using AthleteManagementApp.Data;
using AthleteManagementApp.Repositories;
using AthleteManagementApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the HTTP request pipeline.
builder.Services.AddDbContext<AthleteManagementSystemDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("AthleteManagementSystemDbConnectionString")));
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

var app = builder.Build();
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
