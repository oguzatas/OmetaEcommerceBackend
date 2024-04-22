using Microsoft.Extensions.DependencyInjection;
using OmetaEticaretAPI.Infrastructure.Services;
using OmetaETicaretAPI.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmetaEticaretAPI.Infrastructure
{
    public static  class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
        }
    }
}
