using System.Data.Entity.ModelConfiguration;
using SalaoDoPantcho.Entity.Sistema.Relationship;

namespace SalaoDoPantcho.SGBD.Configurations.Relationship
{
    public class ClientesDatasComemorativasConfiguration : EntityTypeConfiguration<ClientesDatasComemorativas>
    {
        public ClientesDatasComemorativasConfiguration()
        {
            ToTable("TBClientesDatasComemorativas");

            // Chave composta (IdCliente e IdDataComemorativa) na tabela TBClientesDatasComemorativas criada pelo modificador new...
            HasKey(clientesDatasComemorativas => new { clientesDatasComemorativas.IdCliente, clientesDatasComemorativas.IdDataComemorativa });

            Property(clientesDatasComemorativas => clientesDatasComemorativas.IdCliente).HasColumnName("IdCliente");
            Property(clientesDatasComemorativas => clientesDatasComemorativas.IdDataComemorativa).HasColumnName("IdDataComemorativa");

            #region Associações

            HasRequired(clientesDatasComemorativas => clientesDatasComemorativas.Cliente)
            .WithMany(cliente => cliente.DatasComemorativas)
            .HasForeignKey(clientesDatasComemorativas => clientesDatasComemorativas.IdCliente);

            //_______________________________________________________________________

            HasRequired(clientesDatasComemorativas => clientesDatasComemorativas.DatasComemorativas)
            .WithMany(datasComemorativas => datasComemorativas.Clientes)
            .HasForeignKey(clientesDatasComemorativas => clientesDatasComemorativas.IdDataComemorativa);

            #endregion
        }
    }
}