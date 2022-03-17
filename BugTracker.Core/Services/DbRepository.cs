using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugTracker.Core.Contracts;
using BugTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Core.Services
{
    public class DbRepository : IRepository
    {
        private readonly DbContext dbContext;

        public DbRepository(BugTrackerDbContext context)
        {
            this.dbContext = context;
        }

        public void Add<T>(T entity) where T : class
        {
            DbSet<T>().Add(entity);
        }

        public int SaveChanges()
        {
            return dbContext.SaveChanges();
        }

        public IQueryable<T> All<T>() where T : class
        {
            return DbSet<T>().AsQueryable();
        }

        public void Remove<T>(T entity) where T : class
        {
            DbSet<T>().Remove(entity);
        }

       

        private DbSet<T> DbSet<T>() where T : class
        {
            return dbContext.Set<T>();
        }
    }
}
