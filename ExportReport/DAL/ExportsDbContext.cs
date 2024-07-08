using ExportReport.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ExportReport.DAL
{
    public class ExportsDbContext : DbContext
    {
        public DbSet<ExportHistory> ExportHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
        }
    }
}
