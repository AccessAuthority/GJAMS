using Microsoft.EntityFrameworkCore;

namespace GJAMS.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
       public DbSet<Table_2> Table_2 { get; set; }
       public DbSet<Table_1> Table_1 { get; set; }
       public DbSet<AdmitCard> AdmitCard { get; set; }
       public DbSet<Result> Result { get; set; }
       public DbSet<AdminTable> AdminTable { get; set; }
    }
}
