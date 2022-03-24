using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Core.Contracts
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;

        int SaveChanges();

        IQueryable<T> All<T>() where T : class;

        void Remove<T>(T entity) where T : class;

        public IQueryable<T> Include<T>(T entity) where T : class;


    }
}
