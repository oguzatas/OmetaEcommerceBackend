using Microsoft.EntityFrameworkCore;
using OmetaETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OmetaETicaretAPI.Application.Repositories
{
	public interface IRepository<T> where T : BaseEntity
	{
		public interface IRepository<T> where T : BaseEntity
		{
			DbSet<T> Table { get; }
		}
	}
}
