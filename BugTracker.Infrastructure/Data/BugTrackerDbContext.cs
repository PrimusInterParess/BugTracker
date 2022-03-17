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


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.DepartmentEmployees)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.Entity<Priority>().HasData(new []
            //{
            //    new Priority(){Name = "low"},
            //    new Priority(){Name = "normal"},
            //    new Priority(){Name = "urgent"},
            //    new Priority(){Name = "emergency"}
            //});

            //builder.Entity<Status>().HasData(new[]
            //{
            //    new Status(){Name = "new"},
            //    new Status(){Name = "in progress"},
            //    new Status(){Name = "on hold"},
            //    new Status(){Name = "solved"},
            //    new Status(){Name = "closed"}
            //});

            base.OnModelCreating(builder);

        }
    }
}