using KhoraControl.Model;
using Microsoft.EntityFrameworkCore;

namespace KhoraControl.Setup.Database
{
    public class KhoraContext : DbContext
    {
        private string _connectionString;

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
            string dbDiretorio = Path.Combine(Directory.GetCurrentDirectory(), "db");
            if (!Directory.Exists(dbDiretorio))
            {
                Directory.CreateDirectory(dbDiretorio);
            }
            string PathArquivo = Path.Combine(dbDiretorio, "System.db");

            _connectionString = $"Data Source = {PathArquivo};Cache=Shared";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite(_connectionString).UseLazyLoadingProxies();

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
