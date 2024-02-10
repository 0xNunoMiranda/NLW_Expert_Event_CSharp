using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class AuctionDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\nuno_\\source\\repos\\NLW_Expert_Event\\src\\API\\DB\\leilaoDbNLW.db");
        }
    }
}
