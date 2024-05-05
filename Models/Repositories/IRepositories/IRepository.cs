using DAL.db;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.IRepositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Filter (Expression< Func<T, bool>> predicate);
        Task<IEnumerable<T>> FilterAsync (Expression< Func<T, bool>> predicate);
        void Remove (T entity);
        void Add (T entity);
        Task AddAsync (T entity);
        Task<int> SaveAsync();
        int Save();
        T? Find(object id);
    }
}
