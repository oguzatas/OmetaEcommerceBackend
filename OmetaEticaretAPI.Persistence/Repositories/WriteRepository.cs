using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OmetaEticaretAPI.Persistence.Contexts;
using OmetaETicaretAPI.Application.Repositories;
using OmetaETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OmetaEticaretAPI.Persistence.Repositories
{
	public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
	{
		private readonly ECommerceAPIDbContext _context;

        public WriteRepository(ECommerceAPIDbContext context)
        {
            _context = context;
        }
		public DbSet<T> Table => _context.Set<T>();
        public async Task<bool> AddAsync(T entity)
		{
			EntityEntry<T> entityEntry = await Table.AddAsync(entity);
			return entityEntry.State == EntityState.Added;
		}
			

		public async Task<bool> AddRangeAsync(List<T> entity)
		{
			await Table.AddRangeAsync(entity);
			return true;
		}

		public IQueryable<T> GetAll()
		{
			throw new NotImplementedException();
		}

		public Task<T> GetByIdAsync(string id)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
		{
			throw new NotImplementedException();
		}

		public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
		{
			throw new NotImplementedException();
		}

		public bool Remove(T entity)
		{
			EntityEntry<T> entityEntry = Table.Remove(entity);
			return entityEntry.State == EntityState.Deleted;
		}

		public async Task<bool> RemoveAsync(string id)
		{
			T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
			return Remove(model);
		}

		public bool RemoveRange(List<T> entity)
		{
			Table.RemoveRange(entity);
			return true;
		}

		public async Task<int> SaveAsync()
		=> await _context.SaveChangesAsync();

		public bool Update(T entity)
		{
			EntityEntry entityEntry = Table.Update(entity);
			return entityEntry.State == EntityState.Modified;
		}
	}
}
