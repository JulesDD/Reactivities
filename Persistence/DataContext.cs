using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    //add :DbContext and use Microsoft.EntityFramework
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //using Domain
        public DbSet<Activity> Activities { get; set; }
    }
}