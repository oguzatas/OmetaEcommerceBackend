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
    public class ProductImageFileWriteRepository : WriteRepository<f.ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
