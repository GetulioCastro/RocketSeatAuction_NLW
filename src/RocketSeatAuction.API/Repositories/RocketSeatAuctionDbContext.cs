using Microsoft.EntityFrameworkCore;
using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.Repositories
{
    public class RocketSeatAuctionDbContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\Downloads\leilaoDbNLW.db");
        }
    }
}
