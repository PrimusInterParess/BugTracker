using BugTracker.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;

namespace BugTracker.Infrastructure.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class BugTrackerDbContext : IdentityDbContext<User>
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

        public DbSet<BugEmployee> BugsEmployees { get; set; }

        public DbSet<ProjectEmployee> ProjectsEmployees { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Administrator>()
                .HasOne<User>()
                .WithOne()
                .HasForeignKey<Administrator>(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Employee>()
                .HasOne<User>()
                .WithOne()
                .HasForeignKey<Employee>(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder
                  .Entity<Administrator>()
                 .HasMany(a => a.Organizations)
                 .WithOne(o => o.Administrator)
                 .OnDelete(DeleteBehavior.Cascade);

           
            builder
                .Entity<Organization>()
                .HasOne(o => o.Administrator)
                .WithMany(o => o.Organizations)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Department>()
                .HasOne(d => d.Organization)
                .WithMany(o => o.Departments)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Project>()
                .HasOne(p => p.Department)
                .WithMany(d => d.Projects)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Project>()
                .HasOne(p => p.Organization)
                .WithMany(o => o.OrganizationProjects)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Employee>()
                .HasOne(e => e.Organization)
                .WithMany(o => o.OrganizationEmployees)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.DepartmentEmployees)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Bug>()
                .HasOne(b => b.Organization)
                .WithMany(o => o.Bugs)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Bug>()
                .HasOne(b => b.Project)
                .WithMany(p => p.Bugs)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Bug>()
                .HasOne(b=>b.Department)
                .WithMany(d=>d.Bugs)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Bug>()
                .HasOne(b => b.CreatedBy)
                .WithMany(e => e.BugsCreated)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Bug>()
                .HasOne(b => b.Priority)
                .WithMany(p => p.PriorityBugs)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Bug>()
                .HasOne(b => b.Status)
                .WithMany(s => s.StatusBugs)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Comment>()
                .HasOne(c => c.Bug)
                .WithMany(b => b.Comments)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .OnDelete(DeleteBehavior.NoAction);


            builder
                .Entity<BugEmployee>()
                .HasKey(k => new { k.BugId, k.EmployeeId });

            builder
                .Entity<ProjectEmployee>()
                .HasKey(k => new { k.EmployeeId, k.ProjectId });

            base.OnModelCreating(builder);

        }
    }
}