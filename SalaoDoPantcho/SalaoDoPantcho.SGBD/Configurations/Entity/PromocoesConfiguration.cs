using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Configurations.Entity
{
    public class PromocoesConfiguration : EntityTypeConfiguration<Promocoes>
    {
        public PromocoesConfiguration()
        {
            ToTable("TBPromocoes");
            HasKey(promocao => promocao.IdPromocao);

            Property(promocao => promocao.IdPromocao).HasColumnName("IdPromocao").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(promocao => promocao.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(promocao => promocao.Descricao).HasColumnName("Descricao").HasMaxLength(100);
            Property(promocao => promocao.DataInicio).HasColumnName("DataInicio").IsRequired();
            Property(promocao => promocao.DataFim).HasColumnName("DataFim").IsRequired();
            Property(promocao => promocao.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(promocao => promocao.DataAlteracao).HasColumnName("DataAlteracao");
        }
    }
}