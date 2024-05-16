using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmetaEticaretAPI.Persistence.Contexts;
using OmetaETicaretAPI.Application.Repositories;
using OmetaETicaretAPI.Domain.Entities;

namespace OmetaEticaretAPI.Persistence.Repositories
{
    public class MenuReadRepository : ReadRepository<Menu>, IMenuReadRepository
    {
        public MenuReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
