using Microsoft.Extensions.DependencyInjection;
using OmetaEticaretAPI.Infrastructure.Services;
using OmetaETicaretAPI.Application.Abstractions.Storage;
using OmetaEticaretAPI.Infrastructure.Services.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OmetaEticaretAPI.Infrastructure.enums;
using OmetaEticaretAPI.Infrastructure.Services.Storage.Local;
using OmetaETicaretAPI.Application.Abstractions.Services.Configurations;
using OmetaETicaretAPI.Application.Abstractions.Services;
using OmetaETicaretAPI.Application.Abstractions.Token;
using OmetaEticaretAPI.Infrastructure.Services.Configurations;
using OmetaEticaretAPI.Infrastructure.Services.Storage.Azure;
using OmetaEticaretAPI.Infrastructure.Services.Token;

namespace OmetaEticaretAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
            serviceCollection.AddScoped<IMailService, MailService>();
            serviceCollection.AddScoped<IApplicationService, ApplicationService>();
            serviceCollection.AddScoped<IQRCodeService, QRCodeService>();
        }
        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : Storage, IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }
        public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    serviceCollection.AddScoped<IStorage, AzureStorage>();
                    break;
                case StorageType.AWS:

                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
