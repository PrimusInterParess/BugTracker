

using BugTracker.Infrastructure.Data.Models;
using BugTracker.Infrastructure.Models;
using BugTracker.WebConstants;
using Microsoft.AspNetCore.Identity;

namespace BugTracker.Infrastructure
{
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.EntityFrameworkCore;
    using Data;


    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            var scopedServices = app.ApplicationServices.CreateScope();

            var serviceProvider = scopedServices.ServiceProvider;
            
           
            MigrateDatabase(serviceProvider);
            SeedPriorities(serviceProvider);
            SeedStatus(serviceProvider);
            SeedModerator(serviceProvider);

            return app;
        }

        private static void MigrateDatabase(IServiceProvider services)
        {
            var repo = services.GetRequiredService<BugTrackerDbContext>();

            repo.Database.Migrate();
        }

        private static void SeedModerator(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<User>>();

            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task.Run(async () =>
           {
               if (await roleManager.RoleExistsAsync(Roles.ModeratorRoleName))
               {
                   return;
               }

               var role = new IdentityRole { Name = Roles.ModeratorRoleName };

               await roleManager.CreateAsync(role);

               const string moderatorEmail = "mdrtr@btr.com";

               const string moderatorPassword = "moderator123";

               var user = new User()
               {
                   Email = moderatorEmail,
                   UserName = moderatorEmail,
                   FullName = "Moderator",
               };


               await userManager.CreateAsync(user, moderatorPassword);

               await userManager.AddToRoleAsync(user, role.Name);
           })
                .GetAwaiter()
                .GetResult();
        }

        private static void SeedStatus(IServiceProvider services)
        {
            var repo = services.GetRequiredService<BugTrackerDbContext>();

            if (repo.Status.Any())
            {
                return;
            }

            repo.Status.AddRange(new[]
            {
                new Status(){Name = "new"},
                new Status(){Name = "in progress"},
                new Status(){Name = "on hold"},
                new Status(){Name = "solved"},
                new Status(){Name = "closed"}
            });

            repo.SaveChanges();
        }

        private static void SeedPriorities(IServiceProvider services)
        {
            var repo = services.GetRequiredService<BugTrackerDbContext>();

            if (repo.Priorities.Any())
            {
                return;
            }

            repo.Priorities.AddRange(new[]
            {
                new Priority(){Name = "low"},
                new Priority(){Name = "normal"},
                new Priority(){Name = "urgent"},
                new Priority(){Name = "emergency"}
            });

            repo.SaveChanges();

        }
    }
}
