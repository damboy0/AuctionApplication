using System;
using System.Collections.Generic;
using AuctionApplication.Entities.Enums;
using AuctionApplication.Contracts;


namespace AuctionApplication.Entities
{
    public class Asset: AuditableEntity
    {
        public decimal Price { get; set; }
        public decimal SoldPrice { get; set; }
        public string AssetName { get; set; }
        public string ImageUrl { get; set; }
        public bool AuctionPriceIsOpened { get; set; }
        public int AutioneerId {get;set;}
        public Customer Autioneer { get; set; }
        public int? AuctionId {get; set;}
        public Auction Auction {get;set;}
        public int? BuyerId {get;set;}
        //public Customer Buyer {get;set;}
        public List<Bidding> Biddings{get; set;} = new List<Bidding>();
        public AssetStatus AssetStatus{get; set; }
    }
}
