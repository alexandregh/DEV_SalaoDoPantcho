using System.Data.Entity.ModelConfiguration;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.SGBD.Configurations.Relationship
{
    public class ClientesPromocoesConfiguration : EntityTypeConfiguration<ClientesPromocoes>
    {
        public ClientesPromocoesConfiguration()
        {
            ToTable("TBClientesPromocoes");

            // Chave composta (IdCliente e IdPromocao) na tabela TBClientesPromocoes criada pelo modificador new...
            HasKey(clientesPromocoes => new { clientesPromocoes.IdCliente, clientesPromocoes.IdPromocao });

            Property(clientesPromocoes => clientesPromocoes.IdCliente).HasColumnName("IdCliente");
            Property(clientesPromocoes => clientesPromocoes.IdPromocao).HasColumnName("IdPromocao");

            #region Associações

            HasRequired(clientesPromocoes => clientesPromocoes.Cliente)
            .WithMany(cliente => cliente.Promocoes)
            .HasForeignKey(clientesPromocoes => clientesPromocoes.IdCliente);

            //_______________________________________________________________________

            HasRequired(clientesPromocoes => clientesPromocoes.Promocao)
            .WithMany(promocao => promocao.Clientes)
            .HasForeignKey(clientesPromocoes => clientesPromocoes.IdPromocao);

            #endregion
        }
    }
}