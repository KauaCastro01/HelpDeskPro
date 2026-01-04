using HelpDeskPro.Support.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpDeskPro.Support.Data
{
    public class AppDbContext : DbContext
    {
        private readonly string _db;

        public AppDbContext()
        {
            _db = Path.Combine(@"C:\Projetos\HelpDeskPro\HelpDeskPro\Data", "HelpDeskPro.db");
        }

        public AppDbContext(string db)
        {
            _db = db;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={_db}");

        public DbSet<UsuarioAdminModel> UsuarioAdmin { get; set; }
        public DbSet<UsuarioClientModel> UsuarioClient { get; set; }
        public DbSet<ChamadoModel> Chamado { get; set; }
    }
}
