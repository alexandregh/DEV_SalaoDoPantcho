using System.Data.Entity.ModelConfiguration;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.SGBD.Configurations.Relationship
{
    public class ClientesServicosConfiguration : EntityTypeConfiguration<ClientesServicos>
    {
        public ClientesServicosConfiguration()
        {
            ToTable("TBClientesServicos");

            // Chave composta (IdCliente e IdServico) na tabela TBClientesServicos criada pelo modificador new...
            HasKey(clientesServicos => new { clientesServicos.IdCliente, clientesServicos.IdServico });

            Property(clientesServicos => clientesServicos.IdCliente).HasColumnName("IdCliente");
            Property(clientesServicos => clientesServicos.IdServico).HasColumnName("IdServico");

            #region Associações

            HasRequired(clientesServicos => clientesServicos.Cliente)
            .WithMany(cliente => cliente.Servicos)
            .HasForeignKey(clientesServicos => clientesServicos.IdCliente);

            //_______________________________________________________________________

            HasRequired(clientesServicos => clientesServicos.Servico)
            .WithMany(servico => servico.Clientes)
            .HasForeignKey(clientesServicos => clientesServicos.IdServico);

            #endregion
        }
    }
}