using API.Entities;
using API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.UseCases.Auctions.GetCurrent
{
    public class GetCurrentAuctionUseCase
    {


        public Auction Execute()
        {
            var repository = new AuctionDbContext();
            return repository
                .Auctions
                .Include( x => x.Items)
                .First();
        }
    }
}
