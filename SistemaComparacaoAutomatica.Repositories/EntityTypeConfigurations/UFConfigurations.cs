using SistemaComparacaoAutomatica.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace SistemaComparacaoAutomatica.Data.EntityTypeConfigurations
{
    public class UFConfigurations : EntityTypeConfiguration<UF>
    {
        public UFConfigurations()
        {
            Property(x => x.CodUF)
                .HasColumnName("PK_COD_UF")
                .IsRequired();
            HasKey(x => x.CodUF);

            Property(x => x.Abreviatura)
                .HasColumnName("NME_ABREV")
                .HasMaxLength(UF.AbreviaturaUFMaxLength)
                .IsRequired();

            Property(x => x.Descricao)
                .HasColumnName("NME_DESCRICAO")
                .HasMaxLength(UF.DescricaoUFMaxLength)
                .IsRequired();

        }
    }
}
