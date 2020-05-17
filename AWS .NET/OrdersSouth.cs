﻿using System;
using System.Collections.Generic;

namespace AWS_.NET
{
    public partial class OrdersSouth
    {
        public double RowId { get; set; }
        public string Id { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ShipDate { get; set; }
        public string ShipMode { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Segment { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double? PostalCode { get; set; }
        public string Region { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string ProductName { get; set; }
        public decimal? Amount { get; set; }
        public int? Quantity { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Profit { get; set; }
    }
}
