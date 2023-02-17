using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Psinder.Core.Interfaces;
using Psinder.Core.Model;
using Psinder.Repository;
using Psinder.Repository.Repository;
using Psinder.Services.DogServices;
using Psinder.Services.MeetingServices;
using Psinder.Services.ParkServices;
using Psinder.Services.UserServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IDogRepository, DogRepository>();
builder.Services.AddTransient<IParkRepository, ParkRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IMeetingRepository, MeetingRepository>();

builder.Services.AddTransient<IUserServices, UserServices>();
builder.Services.AddTransient<IDogServices, DogServices>();
builder.Services.AddTransient<IMeetingServices, MeetingServices>();
builder.Services.AddTransient<IParkServices, ParkServices>();



var connectionString = builder.Configuration.GetConnectionString("PiesDatabase") ?? throw new InvalidOperationException("Connection string 'connectionString' not found.");
builder.Services.AddDbContext<PsinderContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<User, IdentityRole<string>>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<PsinderContext>();

builder.Services.AddRazorPages();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();

    using (var services = app.Services.CreateScope())
    {
        var dbContext = services.ServiceProvider.GetRequiredService<PsinderContext>();
        try
        {
            dbContext.Database.Migrate();
        }
        catch
        {
            dbContext.Database.CloseConnection();
            dbContext.Database.EnsureDeleted();
            dbContext.Database.Migrate();
        }
    }
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(async (context, next) =>
{
    await next();
    if (context.Response.StatusCode == StatusCodes.Status404NotFound)
    {
        context.Request.Path = "/Home/Error404";
        await next();
    }
});


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
