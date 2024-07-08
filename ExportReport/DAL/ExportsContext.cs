using ExportReport.Models;
using System.Data.Entity;

namespace ExportReport.DAL
{
    public class ExportsContext : DbContext
    {
        public DbSet<Export> Exports { get; set; }
    }
}
