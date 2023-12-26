using OmetaETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaETicaretAPI.Application.Repositories
{
	public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
	{
		Task<bool> AddAsync(T entity);

		Task<bool> AddRangeAsync(List<T> entity);

		bool Remove(T entity);

		Task<bool> RemoveAsync(string id);

		bool RemoveRange(List<T> entity);


		bool Update(T entity);

		Task<int> SaveAsync();
	}
}
