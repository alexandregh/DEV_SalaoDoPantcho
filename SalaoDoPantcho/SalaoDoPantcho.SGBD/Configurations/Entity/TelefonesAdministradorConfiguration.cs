using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Configurations.Entity
{
    public class TelefonesAdministradorConfiguration : EntityTypeConfiguration<TelefonesAdministrador>
    {
        public TelefonesAdministradorConfiguration()
        {
            ToTable("TBTelefonesAdministradores");
            HasKey(telefone => telefone.IdTelefone);

            Property(telefone => telefone.IdTelefone).HasColumnName("IdTelefone").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(telefone => telefone.DDD).HasColumnName("DDD");
            Property(telefone => telefone.Numero).HasColumnName("Numero").IsRequired();
            Property(servicos => servicos.TipoTelefone).HasColumnName("TipoTelefone");
            Property(servicos => servicos.DataCadastro).HasColumnName("DataCadastro").IsRequired();
            Property(servicos => servicos.DataAlteracao).HasColumnName("DataAlteracao");

            #region Associações

            HasRequired(telefoneAdministrador => telefoneAdministrador.Administrador).WithMany(administrador => administrador.TelefonesAdministrador);

            #endregion
        }
    }
}