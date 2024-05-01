using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using f = OmetaETicaretAPI.Domain.Entities.InvoiceFile;

namespace OmetaETicaretAPI.Application.Repositories
{
    public interface IInvoiceFileReadRepository : IReadRepository<f>
    {
    }
}
