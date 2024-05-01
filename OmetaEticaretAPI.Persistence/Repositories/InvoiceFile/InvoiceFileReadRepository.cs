using OmetaEticaretAPI.Persistence.Contexts;
using OmetaEticaretAPI.Persistence.Migrations;
using OmetaETicaretAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using f = OmetaETicaretAPI.Domain.Entities;

namespace OmetaEticaretAPI.Persistence.Repositories
{
    public class InvoiceFileReadRepository : ReadRepository<f.InvoiceFile>, IInvoiceFileReadRepository
    {
        public InvoiceFileReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
