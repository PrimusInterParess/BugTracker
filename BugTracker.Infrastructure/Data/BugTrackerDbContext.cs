using BugTracker.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;

namespace BugTracker.Infrastructure.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class BugTrackerDbContext : IdentityDbContext
    {
        public BugTrackerDbContext(DbContextOptions<BugTrackerDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=BugTracker;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<Priority> Priorities { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Bug> Bugs { get; set; }

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Comment> Comments { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Organization>().HasMany(o => o.OrganizationProjects).WithOne(p => p.Organization)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Organization>().HasMany(o => o.OrganizationEmployees).WithOne(e => e.Organization)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Administrator>()
                 .HasMany(a => a.Organizations)
                 .WithOne(o => o.Administrator)
                 .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.DepartmentEmployees)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Administrator>()
                .HasOne<IdentityUser>()
                .WithOne()
                .HasForeignKey<Administrator>(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Bug>().HasOne(b => b.Priority)
                .WithMany(p => p.PriorityBugs)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Bug>().HasOne(b => b.Status)
                .WithMany(s => s.StatusBugs)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Bug>()
                .HasOne(b => b.Project)
                .WithMany(p => p.Bugs)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Bug>()
                .HasMany(b => b.BugEmployees)
                .WithMany(e => e.EmployeeBugs);

            builder.Entity<Bug>()
                .HasMany(b => b.Comments)
                .WithOne(c => c.Bug)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Department>()
                .HasOne(d => d.Organization)
                .WithMany(o => o.Departments)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Department>()
                .HasMany(d => d.Projects)
                .WithOne(p => p.Department)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Department>()
                .HasMany(d => d.DepartmentEmployees)
                .WithOne(e => e.Department)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Project>()
                .HasMany(p => p.Employees)
                .WithMany(e => e.Projects);

            builder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Priority>().HasData(new[]
            {
                new Priority(){Name = "low"},
                new Priority(){Name = "normal"},
                new Priority(){Name = "urgent"},
                new Priority(){Name = "emergency"}
            });

            builder.Entity<Status>().HasData(new[]
            {
                new Status(){Name = "new"},
                new Status(){Name = "in progress"},
                new Status(){Name = "on hold"},
                new Status(){Name = "solved"},
                new Status(){Name = "closed"}
            });

            base.OnModelCreating(builder);

        }
    }
}