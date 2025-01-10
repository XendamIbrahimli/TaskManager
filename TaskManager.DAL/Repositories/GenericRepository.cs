using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Models.Common;
using TaskManager.Core.Repositories;
using TaskManager.DAL.Context;

namespace TaskManager.DAL.Repositories
{
    public class GenericRepository<T>(AppDbContext _context) : IGenericRepository<T> where T : BaseEntity, new()
    {
        protected DbSet<T> Table => _context.Set<T>();
        public async Task AddAsync(T entity)
            => await _context.AddAsync(entity);

        public IQueryable<T> GetAll()
            =>Table.AsQueryable();

        public async Task<T> GetByIdAsync(int id)
            => await Table.FirstOrDefaultAsync(x=>x.Id==id);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method).AsQueryable();

        public async Task<bool> IsExistAsync(int id)
            =>await Table.AnyAsync(x=>x.Id==id);

        public void Remove(T entity)
            =>Table.Remove(entity);

        public async Task<bool> RemoveAsync(int id)
        {
            int result=await Table.Where(x=>x.Id==id).ExecuteDeleteAsync();
            return result>0;
        }

        public async Task<int> SaveAsync()
            =>await _context.SaveChangesAsync();
    }
}
