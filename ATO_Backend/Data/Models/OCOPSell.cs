﻿namespace Data.Models
{
    public class OCOPSell
    {
        public Guid OCOPSellId { get; set; }
        public double SellVolume { get; set; }
        public double SalePrice { get; set; }
        public DateTime? ManufacturingDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool? ActiveStatus { get; set; }
        //FK
        public Guid ProductId { get; set; }
        public virtual Product? Product { get; set; }
    }

}
