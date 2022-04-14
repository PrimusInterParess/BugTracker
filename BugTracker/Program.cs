
using BugTracker.Core.Contracts;
using BugTracker.Core.Services;
using BugTracker.Infrastructure;
using BugTracker.Infrastructure.Data;
using BugTracker.Infrastructure.Models;
using BugTracker.ModelBinders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<BugTrackerDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services
    .AddTransient<IRepository, DbRepository>()
    .AddTransient<IBugService, BugService>()
    .AddTransient<IValidationService, ValidationService>()
    .AddTransient<IOrganizationService, OrganizationService>()
    .AddTransient<IDepartmentService, DepartmentService>()
    .AddTransient<IAdministratorService, AdministratorService>()
    .AddTransient<IUserService, UserService>()
    .AddTransient<IEmployeeService, EmployeeService>()
    .AddTransient<IProjectService, ProjectService>();

builder.Services.AddDefaultIdentity<User>(options =>
    {
        options.Password.RequireDigit = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        // options.SignIn.RequireConfirmedAccount = false;
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<BugTrackerDbContext>();
builder.Services.AddControllersWithViews()
    .AddMvcOptions(options =>
    {
        options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
        options.ModelBinderProviders.Insert(1, new DoubleModelBinderProvider());
    });

var app = builder.Build();

app.PrepareDatabase();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}

app.UseHttpsRedirection()
    .UseStaticFiles()
    .UseRouting()
    .UseAuthentication()
    .UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{Controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.UseAuthentication();
app.Run();
