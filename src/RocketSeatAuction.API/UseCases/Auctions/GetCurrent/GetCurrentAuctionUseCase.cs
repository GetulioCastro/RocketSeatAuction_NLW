using Microsoft.EntityFrameworkCore;
using RocketSeatAuction.API.Entities;
using RocketSeatAuction.API.Repositories;
using System.Security.Cryptography.X509Certificates;

namespace RocketSeatAuction.API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {
        public Auction? Execute()
        {
            var repository = new RocketSeatAuctionDbContext();

            var today = DateTime.Now;

            return repository
                .Auctions
                .Include(auction => auction.Items)
                .FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
        }
    }
}
