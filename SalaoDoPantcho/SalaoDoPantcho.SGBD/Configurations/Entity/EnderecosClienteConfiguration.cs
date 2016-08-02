using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Configurations.Entity
{
    public class EnderecosClienteConfiguration : EntityTypeConfiguration<EnderecosCliente>
    {
        public EnderecosClienteConfiguration()
        {
            ToTable("TBEnderecosClientes");
            HasKey(endereco => endereco.IdEnderecoCli);

            Property(endereco => endereco.IdEnderecoCli).HasColumnName("IdEndereco").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(endereco => endereco.TipoEndereco).HasColumnName("TipoEndereco");
            Property(endereco => endereco.Descricao).HasColumnName("Descricao").HasMaxLength(100).IsRequired();
            Property(endereco => endereco.Numero).HasColumnName("Numero").HasMaxLength(6);
            Property(endereco => endereco.Complemento).HasColumnName("Complemento").HasMaxLength(100);
            Property(endereco => endereco.Bairro).HasColumnName("Bairro").HasMaxLength(50).IsRequired();
            Property(endereco => endereco.CEP).HasColumnName("CEP").HasMaxLength(10).IsRequired();
            Property(endereco => endereco.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(endereco => endereco.DataAlteracao).HasColumnName("DataAlteracao");
        }
    }
}