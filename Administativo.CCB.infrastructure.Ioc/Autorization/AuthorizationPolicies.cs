using Administrativo.CCB.Dominio.Entity.Enum;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administativo.CCB.infrastructure.Ioc.Autorization
{
    public static class AuthorizationPolicies
    {
        public static void AuthorizationDeAcessos(this AuthorizationOptions options)
        {
            options.AddPolicy("Admin", policy => policy.RequireRole(Atividades.Administrador.ToString()));
            options.AddPolicy("Tesoureiro", policy => policy.RequireRole(Atividades.Tesoreiro.ToString()));
            options.AddPolicy("FundoBiblico", policy => policy.RequireRole(Atividades.ColaboradorFudoBiblico.ToString()));
        }
    }
}
