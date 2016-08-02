using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Configurations.Entity
{
    class AdministradoresConfiguration : EntityTypeConfiguration<Administradores>
    {
        public AdministradoresConfiguration()
        {
            ToTable("TBAdministradores");
            HasKey(administrador => administrador.IdAdministrador);

            Property(administrador => administrador.IdAdministrador).HasColumnName("IdAdministrador").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(administrador => administrador.Nome).HasColumnName("Nome").HasMaxLength(50).IsRequired();
            Property(administrador => administrador.Email).HasColumnName("Email").HasMaxLength(50).IsRequired();
            Property(administrador => administrador.Login).HasColumnName("Login").HasMaxLength(50).IsRequired();
            Property(administrador => administrador.Senha).HasColumnName("Senha").HasMaxLength(30).IsRequired();
            Property(administrador => administrador.StatusPessoa).HasColumnName("StatusAdministrador").IsRequired();
            Property(administrador => administrador.Senha).HasColumnName("Perfil").IsRequired();
            Property(administrador => administrador.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(administrador => administrador.DataAlteracao).HasColumnName("DataAlteracao");

            #region Associações

            HasRequired(administrador => administrador.EnderecosAdministrador).WithMany(endereco => endereco.Administradores).HasForeignKey(administrador => administrador.IdEnderecoAdm);

            #endregion
        }
    }
}