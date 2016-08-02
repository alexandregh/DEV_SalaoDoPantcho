using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Configurations.Entity
{
    public class ServicosConfiguration : EntityTypeConfiguration<Servicos>
    {
        public ServicosConfiguration()
        {
            ToTable("TBServicos");
            HasKey(servicos => servicos.IdServico);

            Property(servicos => servicos.IdServico).HasColumnName("IdServico").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(servicos => servicos.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(servicos => servicos.Descricao).HasColumnName("Descricao").HasMaxLength(100);
            Property(servicos => servicos.Preco).HasColumnName("Preco").HasPrecision(18, 2).IsRequired();
            Property(servicos => servicos.GeneroServico).HasColumnName("Genero").IsRequired();
            Property(servicos => servicos.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(servicos => servicos.DataAlteracao).HasColumnName("DataAlteracao");
        }
    }
}