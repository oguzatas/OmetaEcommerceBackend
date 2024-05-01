using OmetaEticaretAPI.Persistence.Contexts;
using OmetaETicaretAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaEticaretAPI.Persistence.Repositories
{
    public class FileWriteRepository : WriteRepository<OmetaETicaretAPI.Domain.Entities.File>, IFileWriteRepository
    {
        public FileWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
