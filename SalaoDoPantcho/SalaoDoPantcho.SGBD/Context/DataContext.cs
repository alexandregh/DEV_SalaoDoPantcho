using System;
using System.Data.Entity;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using SalaoDoPantcho.Entity.Sistema.Entity;
using SalaoDoPantcho.Entity.Sistema.Relationship;
using SalaoDoPantcho.SGBD.Configurations.Entity;
using SalaoDoPantcho.SGBD.Configurations.Relationship;

namespace SalaoDoPantcho.SGBD.Context
{
    public class DataContext : DbContext
    {
        #region Construtor

        public DataContext()
            : base(ConfigurationManager.ConnectionStrings["dbSalaoDoPantcho"].ConnectionString)
        {

        }

        #endregion

        #region OnModelCreating

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurations
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //__________________________________________

            // Configurations Data Type
            modelBuilder.Properties<string>().Configure(entity => entity.HasColumnType("varchar"));
            modelBuilder.Properties<DateTime>().Configure(entity => entity.HasColumnType("smalldatetime"));

            //__________________________________________

            // Configurations Entity
            modelBuilder.Configurations.Add(new AcessoriosConfiguration());
            modelBuilder.Configurations.Add(new AdministradoresConfiguration());
            modelBuilder.Configurations.Add(new ClientesConfiguration());
            modelBuilder.Configurations.Add(new DatasComemorativasConfiguration());
            modelBuilder.Configurations.Add(new EnderecosClienteConfiguration());
            modelBuilder.Configurations.Add(new EnderecosAdministradorConfiguration());
            modelBuilder.Configurations.Add(new ProdutosConfiguration());
            modelBuilder.Configurations.Add(new PromocoesConfiguration());
            modelBuilder.Configurations.Add(new ServicosConfiguration());
            modelBuilder.Configurations.Add(new TelefonesClienteConfiguration());
            modelBuilder.Configurations.Add(new TelefonesAdministradorConfiguration());

            //__________________________________________

            // Configurations Relationship
            modelBuilder.Configurations.Add(new ClientesDatasComemorativasConfiguration());
            modelBuilder.Configurations.Add(new ClientesProdutosConfiguration());
            modelBuilder.Configurations.Add(new ClientesPromocoesConfiguration());
            modelBuilder.Configurations.Add(new ClientesServicosConfiguration());
            modelBuilder.Configurations.Add(new ServicosAcessoriosConfiguration());

        }

        #endregion

        #region DbSet Entity

        public DbSet<Acessorios> Acessorios { get; set; }
        public DbSet<Administradores> Administradores { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<DatasComemorativas> DatasComemorativas { get; set; }
        public DbSet<EnderecosCliente> EnderecosCliente { get; set; }
        public DbSet<EnderecosAdministrador> EnderecosAdministrador { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Promocoes> Promocoes { get; set; }
        public DbSet<Servicos> Servicos { get; set; }
        public DbSet<TelefonesCliente> TelefonesCliente { get; set; }
        public DbSet<TelefonesAdministrador> TelefonesAdministrador { get; set; }

        #endregion

        #region DbSet Relationship

        public DbSet<ClientesDatasComemorativas> ClientesDatasComemorativas { get; set; }
        public DbSet<ClientesProdutos> ClientesProdutos { get; set; }
        public DbSet<ClientesPromocoes> ClientesPromocoes { get; set; }
        public DbSet<ClientesServicos> ClientesServicos { get; set; }
        public DbSet<ServicosAcessorios> ServicosAcessorios { get; set; }

        #endregion
    }
}