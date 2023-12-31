using ASPNETMVCCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVCCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        //private DbSet<Employee> myProperty;

        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get ; set; }
    }
}
