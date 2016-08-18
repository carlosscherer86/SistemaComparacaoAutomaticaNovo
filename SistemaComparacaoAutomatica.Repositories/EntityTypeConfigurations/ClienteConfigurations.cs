using SistemaComparacaoAutomatica.Domain.Entities;
using SistemaComparacaoAutomatica.Domain.ValueObject;
using System.Data.Entity.ModelConfiguration;
namespace SistemaComparacaoAutomatica.Data.EntityTypeConfigurations
{
    public class ClienteConfigurations : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfigurations()
        {

            Property(x => x.CodCliente)
                .HasColumnName("PK_COD_CLIENTE")
                .IsRequired();
            HasKey(x => x.CodCliente);

            Property(x => x.Senha)
                .HasColumnName("NME_SENHA")
                .IsRequired();

            Property(x => x.TokenAlteracaoSenha)
                .HasColumnName("NME_TOKEN")
                .IsOptional();

            Property(x => x.Nome)
                .HasColumnName("NME_NOME")
                .IsRequired();

            Property(x => x.Sobrenome)
                .HasColumnName("NME_SOBRENOME")
                .IsRequired();

            Property(x => x.Email.Endereco)
                .HasColumnName("NME_EMAIL")
                .HasMaxLength(Email.EnderecoMaxLength)
                .IsRequired();

            Property(x => x.Endereco.EnderecoCliente)
                .HasColumnName("NME_ENDERECO")
                .HasMaxLength(Endereco.EnderecoClienteMaxLength)
                .IsRequired();

            Property(x => x.Endereco.Bairro)
                .HasColumnName("NME_BAIRRO")
                .HasMaxLength(Endereco.BairroClienteMaxLength)
                .IsRequired();

            Property(x => x.Endereco.Cidade)
                .HasColumnName("NME_CIDADE")
                .HasMaxLength(Endereco.CidadeClienteMaxLength)
                .IsRequired();

            Property(x => x.Endereco.Cep.CepCod)
                .HasColumnName("NME_CEP")
                .IsRequired();

            Property(x => x.Endereco.Complemento)
                .HasColumnName("NME_COMPLEMENTO")
                .HasMaxLength(Endereco.ComplementoMaxLength)
                .IsOptional();

            Property(x => x.Endereco.Numero)
                .HasColumnName("NME_NUMERO")
                .HasMaxLength(Endereco.NumeroClienteMaxLength)
                .IsRequired();

            Property(x => x.DataNascimento)
                .HasColumnName("DTA_NASCIMENTO")
                .IsRequired();

            Property(x => x.Administrador)
                .HasColumnName("STA_ADMIN")
                .IsRequired();

            Property(x => x.UFID)
                .HasColumnName("FK_COD_UF")
                .IsRequired();

            HasRequired(p => p.UF)
                .WithMany()
                .HasForeignKey(p => p.UFID);

        }
    }
}
