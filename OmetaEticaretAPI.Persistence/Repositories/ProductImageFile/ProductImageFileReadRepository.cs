using OmetaEticaretAPI.Persistence.Contexts;
using OmetaETicaretAPI.Application.Repositories.ProductImageFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using f = OmetaETicaretAPI.Domain.Entities;

namespace OmetaEticaretAPI.Persistence.Repositories
{
    public class ProductImageFileReadRepository : ReadRepository<f.ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
