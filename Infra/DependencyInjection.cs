using Domain.Interfaces;
using LabTrans.Infra.Repositories;
using Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServicesInfra(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IReservaRepository, ReservaRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<LabTransContext>(opt => opt
                .UseSqlServer(configuration.GetConnectionString("DB_LabTrans")));

            return services;
        }
    }
}
