using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Configurations.Entity
{
    public class ClientesConfiguration : EntityTypeConfiguration<Clientes>
    {
        public ClientesConfiguration()
        {
            ToTable("TBClientes");
            HasKey(cliente => cliente.IdCliente);

            Property(cliente => cliente.IdCliente).HasColumnName("IdCliente").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(cliente => cliente.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(cliente => cliente.Apelido).HasColumnName("Apelido").HasMaxLength(30);
            Property(cliente => cliente.Email).HasColumnName("Email").HasMaxLength(50).IsRequired();
            Property(cliente => cliente.Login).HasColumnName("Login").HasMaxLength(50).IsRequired();
            Property(cliente => cliente.Senha).HasColumnName("Senha").HasMaxLength(50).IsRequired();
            Property(cliente => cliente.GeneroSexo).HasColumnName("Genero");
            Property(cliente => cliente.StatusPessoa).HasColumnName("StatusCliente").IsRequired();
            Property(cliente => cliente.Perfil).HasColumnName("Perfil").IsRequired();
            Property(cliente => cliente.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(cliente => cliente.DataAlteracao).HasColumnName("DataAlteracao");

            #region Associações

            HasRequired(cliente => cliente.EnderecosCliente).WithMany(endereco => endereco.Clientes).HasForeignKey(cliente => cliente.IdEnderecoCli); //.....

            #endregion
        }
    }
}