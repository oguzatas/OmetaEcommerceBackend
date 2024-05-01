using OmetaETicaretAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using f = OmetaETicaretAPI.Domain.Entities.ProductImageFile;

namespace OmetaETicaretAPI.Application.Repositories.ProductImageFile
{
    public interface IProductImageFileWriteRepository : IWriteRepository<f>
    {
    }
}
