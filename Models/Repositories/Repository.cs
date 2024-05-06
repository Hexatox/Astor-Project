﻿using DAL.db;
using DAL.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T>, IDisposable where T : class
    {
        private AppDbContext appDbContext;
        
        public Repository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Add(T entity)
        {
            appDbContext.Add(entity);
        }

        public async Task AddAsync(T entity)
        {
            await appDbContext.AddAsync(entity);
        }

        public void Dispose()
        {
            appDbContext.Dispose();
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> predicate)
        {
            return appDbContext.Set<T>().Where(predicate);
        }

        public async Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> predicate)
        {
            return await appDbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public T? Find(object id)
        {
            return appDbContext.Set<T>().Find(id);
        }

        public async Task<T?> FindAsync(object id)
        {
            return await appDbContext.Set<T>().FindAsync(id);
        }

        public IEnumerable<T> GetAll()
        {
            return appDbContext.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await appDbContext.Set<T>().ToListAsync();
        }

        public void Remove(T entity)
        {
            appDbContext.Set<T>().Remove(entity);
        }

        public int Save()
        {
            return appDbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await appDbContext.SaveChangesAsync();
        }
    }
}
