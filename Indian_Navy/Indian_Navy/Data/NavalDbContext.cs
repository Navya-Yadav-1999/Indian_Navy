using Indian_Navy.Model;
using Microsoft.EntityFrameworkCore;

namespace Indian_Navy.Data
{
    public class NavalDbContext : DbContext
    {
        public NavalDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<EmployeeData> EmployeeList { get; set; }
        //public DbSet<Base> Bases { get; set; }
        //public DbSet<Posting> PostingData { get; set; }

    }
}
