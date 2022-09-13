using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public class ProductVariant : BaseEntity
    {
        [JsonIgnore]
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal OriginalPrice { get; set; }
    }
}
