using Microsoft.EntityFrameworkCore;
using OmetaETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OmetaEticaretAPI.Persistence.Contexts
{
	public class ECommerceAPIDbContext : DbContext
	{
		public ECommerceAPIDbContext(DbContextOptions options) : base(options)
		{
		
		}

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

		// interceptor
		public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			var datas = ChangeTracker.Entries<BaseEntity>();

			foreach (var data in datas)
			{
				_  = data.State switch
				{
					EntityState.Added => data.Entity.CreateDate = DateTime.UtcNow,
					EntityState.Modified => data.Entity.ChangeDate = DateTime.UtcNow
				};
			}
			return await base.SaveChangesAsync(cancellationToken);
		}
	}
}
