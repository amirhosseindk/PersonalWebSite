using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Cart
{
    public class CartProductResponse
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ProductTypeId { get; set; }
        public string ProductType { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
