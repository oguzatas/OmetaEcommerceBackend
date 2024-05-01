using OmetaEticaretAPI.Persistence.Contexts;
using OmetaETicaretAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using f = OmetaETicaretAPI.Domain.Entities;

namespace OmetaEticaretAPI.Persistence.Repositories
{
    public class InvoiceFileWriteRepository : WriteRepository<f.InvoiceFile>, IInvoiceFileWriteRepository
    {
        public InvoiceFileWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
