﻿using Data.ArmsContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Service.Repository
{
    public class Repository<T>(ATODbContext context) : IRepository<T> where T : class
    {
        private readonly ATODbContext _context = context;

        public IQueryable<T> Query()
        {
            return _context.Set<T>().AsQueryable();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = _context.Set<T>();

            foreach (var include in includes)
            {
                query = query.Include(include);
            }

            return await query.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            _context.Set<T>().Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(T entity)
        {
            await _context.Set<T>().AddRangeAsync(entity);
            await _context.SaveChangesAsync();
        }


        public async Task RealAddRangeAsync(IEnumerable<T> entity)
        {
            await _context.Set<T>().AddRangeAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRangeAsync(T entity)
        {
            _context.Set<T>().UpdateRange(entity);
            await _context.SaveChangesAsync();
        }
    }

}
