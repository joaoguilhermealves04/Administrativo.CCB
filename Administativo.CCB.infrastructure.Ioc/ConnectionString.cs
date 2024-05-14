
using Administrativo.CCB.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Administativo.CCB.infrastructure.Ioc
{
    public static class ConnectionString
    {
        public static IServiceCollection AddAdministativo(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<AdministrativoContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("Administrativo")));

            return services;

        }


        public static IServiceCollection AddFundoBiblico(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FundoBiblicoContext>
                         (options => options.UseSqlServer(configuration.GetConnectionString("Administrativo")));

            return services;

        }
    }
}
