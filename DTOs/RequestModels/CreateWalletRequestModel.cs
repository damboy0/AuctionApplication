namespace AuctionApplication.DTOs.RequestModels
{
    public class CreateWalletRequestModel
    {
         public decimal Amount { get; set; }
         public int CustomerId  {get; set;}
    }
}