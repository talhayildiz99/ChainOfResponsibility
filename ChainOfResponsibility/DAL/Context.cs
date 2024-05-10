using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsibility.DAL
{
    public class Context : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-DSQNOEI\\SQLEXPRESS03; initial catalog = DbChainOf; integrated security = true");
        }
        public DbSet<CustomerProcess> CustomerProcess { get; set; }
    }
}
