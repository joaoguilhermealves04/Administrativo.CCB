using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administrativo.CCB.Repository.Context
{
    public class AdministrativoContext : DbContext
    {
        public AdministrativoContext(DbContextOptions<AdministrativoContext> options) : base(options) { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdministrativoContext).Assembly);
        }
    }
}
