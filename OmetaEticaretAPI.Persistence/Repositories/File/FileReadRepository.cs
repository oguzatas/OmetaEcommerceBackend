using OmetaEticaretAPI.Persistence.Contexts;
using OmetaETicaretAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaEticaretAPI.Persistence.Repositories
{
    public class FileReadRepository : ReadRepository<OmetaETicaretAPI.Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
