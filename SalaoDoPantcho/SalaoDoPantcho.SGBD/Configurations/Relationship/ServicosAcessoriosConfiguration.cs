using System.Data.Entity.ModelConfiguration;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.SGBD.Configurations.Relationship
{
    public class ServicosAcessoriosConfiguration : EntityTypeConfiguration<ServicosAcessorios>
    {
        public ServicosAcessoriosConfiguration()
        {
            ToTable("TBServicosAcessorios");

            // Chave composta (IdServico e IdAcessorio) na tabela TBServicosAcessorios criada pelo modificador new...
            HasKey(servicosAcessorios => new { servicosAcessorios.IdServico, servicosAcessorios.IdAcessorio });

            Property(servicosAcessorios => servicosAcessorios.IdServico).HasColumnName("IdServico");
            Property(servicosAcessorios => servicosAcessorios.IdAcessorio).HasColumnName("IdAcessorio");

            #region Associações

            HasRequired(servicosAcessorios => servicosAcessorios.Servico)
            .WithMany(servico => servico.Acessorios)
            .HasForeignKey(servicosAcessorios => servicosAcessorios.IdServico);

            //_______________________________________________________________________

            HasRequired(servicosAcessorios => servicosAcessorios.Acessorio)
            .WithMany(acessorio => acessorio.Servicos)
            .HasForeignKey(servicosAcessorios => servicosAcessorios.IdAcessorio);

            #endregion
        }
    }
}