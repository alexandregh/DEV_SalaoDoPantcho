using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Configurations.Entity
{
    public class ProdutosConfiguration : EntityTypeConfiguration<Produtos>
    {
        public ProdutosConfiguration()
        {
            ToTable("TBProdutos");
            HasKey(produto => produto.IdProduto);

            Property(produto => produto.IdProduto).HasColumnName("IdProduto").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(produto => produto.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(produto => produto.Descricao).HasColumnName("Descricao").HasMaxLength(50);
            Property(produto => produto.Fabricante).HasColumnName("Fabricante").HasMaxLength(30);
            Property(produto => produto.DataFabricacao).HasColumnName("DataFabricacao");
            Property(produto => produto.DataValidade).HasColumnName("DataValidade");
            Property(produto => produto.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(produto => produto.DataAlteracao).HasColumnName("DataAlteracao");
        }
    }
}