﻿﻿using System;
using System.Collections.Generic;
using AuctionApplication.Contracts;

namespace AuctionApplication.Entities
{
    public class Auction : AuditableEntity
    {
        public decimal StartingPrice { get; set; }
        public string AssetName { get; set; }
        public DateTime ExpiryDate { get;set; }
        public AuctionType AuctionType { get; set; }
        public int CustomerId {get;set;}
        public Customer Customer {get;set;}
        public bool IsApproved { get; set; }
        public bool IsClosed { get; set; }
        public List<Bidding> Biddings{get; set;} = new List<Bidding>();
    }
}
