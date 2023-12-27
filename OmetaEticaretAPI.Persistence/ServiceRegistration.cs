using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OmetaEticaretAPI.Persistence.Contexts;
using OmetaEticaretAPI.Persistence.Repositories;
using OmetaETicaretAPI.Application.Abstractions;
using OmetaETicaretAPI.Application.Repositories;
using OmetaETicaretAPI.Application.Repositories.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaEticaretAPI.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
			


			services.AddDbContext<ECommerceAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

			services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
			services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
			services.AddScoped<IOrderReadRepository, OrderReadRepository>();
			services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
			services.AddScoped<IProductReadRepository, ProductReadRepository>();
			services.AddScoped<IProductWriteRepository, ProductWriteRepository>();


		}
	}
}
