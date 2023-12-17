using OmetaETicaretAPI.Application.Abstractions;
using OmetaETicaretAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaEticaretAPI.Persistence
{
	public class ProductService : IProductService
	{
		public List<Product> GetProducts()
			=> new()
			{
				new() { Id=Guid.NewGuid(), Name="Salam", Price=100, Stock="25"},
				new() { Id=Guid.NewGuid(), Name="Sucuk", Price=100, Stock="25"},
				new() { Id=Guid.NewGuid(), Name="Erişte", Price=100, Stock="25"}


			};

	
	}
}
