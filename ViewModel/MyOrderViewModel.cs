using GrassyWomen.Dto;
using System;
using System.Collections.Generic;
namespace GrassyWomen.ViewModel
{
    public class MyOrderViewModel
    {
        public OrderDto OrderPlaceDetails { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderPlacedTime { get; set; }
        public IEnumerable<MyProductOrderInfo> ProductOrderInfos { get; set; }
    }

    public class MyProductOrderInfo
    {
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
    }
}
