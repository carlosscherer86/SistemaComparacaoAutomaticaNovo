using SistemaComparacaoAutomatica.Data.EntityTypeConfigurations;
using SistemaComparacaoAutomatica.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SistemaComparacaoAutomatica.Data.Contexts
{
    public class SistemaComparacaoContext : DbContext
    {
        public SistemaComparacaoContext() 
            : base("SistemaComparacao")
        {
            //Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<UF> UFs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(150));

            modelBuilder.Configurations.Add(new ClienteConfigurations());
            modelBuilder.Configurations.Add(new UFConfigurations());

        }
    }
}
