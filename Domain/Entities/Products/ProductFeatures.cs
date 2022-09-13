using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public class ProductFeatures : BaseEntity
    {
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public string DisplayName { get; set; } = String.Empty;
        public string Value { get; set; } = String.Empty;
    }
}
