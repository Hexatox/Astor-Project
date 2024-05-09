using BLL.Services.IServices;
using DAL.db;
using DAL.Entities;
using DAL.Repositories.IRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using views_practice.Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Load configuration based on environment
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConntection"))

);// application DbContext

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
}).AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders().AddDefaultUI();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});

// Add Razor Pages services.
builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IUploadFile,UploadFileBlob>();
builder.Services.AddScoped <IEmailSender , EmailSender>();
builder.Services.Scan(scan => scan
    .FromAssemblyOf<AppDbContext>()
    .AddClasses(classes => classes.AssignableTo(typeof(IRepository<>)))
        .AsImplementedInterfaces()
        .WithScopedLifetime()); // this will register all classes that implement IRepository<TEntity> as a service with the same interface

builder.Services.Scan(scan => scan
    .FromAssemblyOf<IService>()
    .AddClasses(classes => classes.AssignableTo(typeof(IService)))
        .AsImplementedInterfaces()
        .WithScopedLifetime()); // this will register all classes that implement IService as a service with the same interface


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.Use(async (context, next) =>
{
    await next();
    if (context.Response.StatusCode == 404)
    {
        context.Request.Path = "/Error/notFound";
        await next();
    }
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); // This is needed to enable authentication.
app.UseAuthorization();


// Map Razor Pages.
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");
    pattern: "{area=Identity}/{controller=Director}/{action=Index}/{id?}");

app.Run();