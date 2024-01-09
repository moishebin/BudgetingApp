using Microsoft.EntityFrameworkCore;

namespace BudgetingApp.Models
{

    public class AppDbContext : DbContext
    {
        //public IConfiguration _config { get; set; }
        //public AppDbContext(IConfiguration config)
        //{
        //    _config = config;
        //}
        public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_config.GetConnectionString("MyConnection"));
        //}

        public DbSet<Budgets> Budgets { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
        public DbSet<Users> Users { get; set; }

    }

}
