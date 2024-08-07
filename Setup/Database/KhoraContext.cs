using KhoraControl.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace KhoraControl.Setup.Database
{
    public class KhoraContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _databaseProvider;

        public DbSet<Veiculo> veiculos { get; set; }
        public DbSet<Entidade> entidade { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<Concessionaria> concessionarias { get; set; }
        public DbSet<CheckList> checklist { get; set; }
        public DbSet<DadosCheckList> dadosCheckLists { get; set; }
        public DbSet<DadosNFe> dadosNFe { get; set; }
        public DbSet<Produtos> produtos { get; set; }

        public KhoraContext()
        {
            // Lê a configuração do App.config
            _databaseProvider = ConfigurationManager.AppSettings["DatabaseProvider"];
            _connectionString = ConfigurationManager.ConnectionStrings[_databaseProvider + "Connection"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_databaseProvider == "SQLite")
            {
                optionsBuilder.UseSqlite(_connectionString).UseLazyLoadingProxies();
            }
            else if (_databaseProvider == "PostgreSQL")
            {
                optionsBuilder.UseNpgsql(_connectionString).UseLazyLoadingProxies();
            }
            else
            {
                throw new InvalidOperationException("Database provider not supported.");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidade>()
                .HasDiscriminator<string>("Tipo")
                .HasValue<Empresa>("Empresa")
                .HasValue<Concessionaria>("Concessionaria");

            base.OnModelCreating(modelBuilder);
        }
    }
}
