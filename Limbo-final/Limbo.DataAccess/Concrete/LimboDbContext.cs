using Limbo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Limbo.DataAccess.Concrete
{
    public class LimboDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=DESKTOP-3HH1MUA\SQLEXPRESS;Initial Catalog=LimboTb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<University> Universities { get; set; }
    }
}
