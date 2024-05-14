using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyModel;
using Scrutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Administativo.CCB.infrastructure.Ioc.InjecaoIdependecia
{
    public static class ScrutorDependencyInjection
    {
        public static IServiceCollection AddClassesMatchingInterfaces(this IServiceCollection services,string @namespace)
        {
            var assemblies = DependencyContext.Default.GetDefaultAssemblyNames().Where(assembly => assembly.FullName.StartsWith(@namespace)).Select(Assembly.Load);

            services.Scan(scan => scan.FromAssemblies(assemblies).AddClasses().UsingRegistrationStrategy(RegistrationStrategy.Skip).AsMatchingInterface().WithScopedLifetime());
            
            return services;

        }
    }
}
