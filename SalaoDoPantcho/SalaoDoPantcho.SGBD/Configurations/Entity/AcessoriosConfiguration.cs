using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Configurations.Entity
{
    public class AcessoriosConfiguration : EntityTypeConfiguration<Acessorios>
    {
        public AcessoriosConfiguration()
        {
            ToTable("TBAcessorios");
            HasKey(acessorio => acessorio.IdAcessorio);

            Property(acessorio => acessorio.IdAcessorio).HasColumnName("IdAcessorio").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(acessorio => acessorio.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(acessorio => acessorio.Nome).HasColumnName("Descricao").HasMaxLength(500);
            Property(acessorio => acessorio.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(acessorio => acessorio.DataAlteracao).HasColumnName("DataAlteracao");
        }
    }
}