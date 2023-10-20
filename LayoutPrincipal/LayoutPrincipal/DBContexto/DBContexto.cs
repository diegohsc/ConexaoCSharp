using LayoutPrincipal.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutPrincipal.BDContexto
{
    public class DBContexto:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                //var conexaoStr = "Server=DIEGO-NOT; Database=Sistema; User ID=sa; Password=121830; Trusted_Connection=False; Integrated Security=SSPI;TrustServerCertificate=True";
                //<add name="DefaultConnection" connectionString="Data Source=ds-01;Initial Catalog=banco_teste_diego;;User Id=sa;Password=dg@etd45H;Integrated Security=False" providerName="System.Data.SqlClient" /> 
                var conexaoStr = "Server=ds-01; Database=banco_teste_diego; User ID=sa; Password=dg@etd45H; TrustServerCertificate=True";
                options.UseSqlServer(conexaoStr);
            }
        }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
