using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using SalaoDoPantcho.Entity.Sistema.Entity;

namespace SalaoDoPantcho.SGBD.Configurations.Entity
{
    public class DatasComemorativasConfiguration : EntityTypeConfiguration<DatasComemorativas>
    {
        public DatasComemorativasConfiguration()
        {
            ToTable("TBDatasComemorativas");
            HasKey(dataComemorativa => dataComemorativa.IdDataComemorativa);

            Property(dataComemorativa => dataComemorativa.IdDataComemorativa).HasColumnName("IdDataComemorativa").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(dataComemorativa => dataComemorativa.Descricao).HasColumnName("Descricao").HasMaxLength(50).IsRequired();
            Property(cliente => cliente.DataComemorativa).HasColumnName("DataComemorativa").IsRequired();
        }
    }
}