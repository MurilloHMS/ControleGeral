using KhoraControl.Model;
using Microsoft.EntityFrameworkCore;

namespace KhoraControl.Setup.Database
{
    public class KhoraContext : DbContext
    {
        private string _connectionString;

        public DbSet<Veiculo> veiculos { get; set; }
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

    }
}
