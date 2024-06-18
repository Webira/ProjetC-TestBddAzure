using Microsoft.EntityFrameworkCore;
using testbdd.Models;

namespace testbdd.Context
{
    public class myContext : DbContext
    {
        public myContext(DbContextOptions<myContext> options)
            : base(options) { }

        public DbSet<User> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=tcp:serverbdduserphoto.database.windows.net,1433;Initial Catalog=mybdduser;Persist Security Info=False;User ID=adminira;Password=blondira100!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
                );
            }
        }
    }
}
