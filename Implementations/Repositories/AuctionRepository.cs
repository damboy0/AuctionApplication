using AuctionApplication.Context;
using AuctionApplication.Entities;
using AuctionApplication.Interface.Repositories;
using Implementations.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AuctionApplication.Implementations.Repositories
{
    public class AuctionRepository : BaseRepository<Auction> , IAuctionRepository 
    {
        public AuctionRepository(ApplicationContext Context)
        {
            _Context = Context;
        }
       public async Task<Auction> GetAsync(int id)
        {
            return await _Context.Auctions
            .Include(auction => auction.Customer)
            .Include(auction => auction.Biddings)
            .SingleOrDefaultAsync(x => x.Id == id);
        } 
    }
}