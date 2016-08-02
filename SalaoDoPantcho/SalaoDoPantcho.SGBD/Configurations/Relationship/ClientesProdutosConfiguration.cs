using System.Data.Entity.ModelConfiguration;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.SGBD.Configurations.Relationship
{
    public class ClientesProdutosConfiguration : EntityTypeConfiguration<ClientesProdutos>
    {
        public ClientesProdutosConfiguration()
        {
            ToTable("TBClientesProdutos");

            // Chave composta (IdCliente e IdProdutos) na tabela TBClientesProdutos criada pelo modificador new...
            HasKey(clientesProdutos => new { clientesProdutos.IdCliente, clientesProdutos.IdProdutos });

            Property(clientesProdutos => clientesProdutos.IdCliente).HasColumnName("IdCliente");
            Property(clientesProdutos => clientesProdutos.IdProdutos).HasColumnName("IdProdutos");

            #region Associações

            HasRequired(clientesProdutos => clientesProdutos.Cliente)
            .WithMany(cliente => cliente.Produtos)
            .HasForeignKey(clientesProdutos => clientesProdutos.IdCliente);

            //_______________________________________________________________________

            HasRequired(clientesProdutos => clientesProdutos.Produto)
            .WithMany(produto => produto.Clientes)
            .HasForeignKey(clientesProdutos => clientesProdutos.IdProdutos);

            #endregion
        }
    }
}