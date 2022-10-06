using AuctionApp.Enum;

namespace Dtos.AuctionDto
{
    public class AuctionDto
    {
        public decimal StartingPrice { get; set; }
        public string AssetName { get; set; }
        public DateTime ExpiryDate { get;set; }
        public AuctionType AuctionType { get; set; }

    }
}