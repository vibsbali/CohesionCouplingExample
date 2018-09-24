using System.Collections.Generic;

namespace EcommerceProjectBefore.Models
{
    public class Cart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
    }

    public class OrderItem
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
    }
}