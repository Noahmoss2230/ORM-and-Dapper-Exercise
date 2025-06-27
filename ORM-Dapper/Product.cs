using System;

namespace ORM_Dapper
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int onSale { get; set; }
        public string StockLevel { get; set; }
    }
}