using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public class ProductImages : BaseEntity
    {
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
        public string Src { get; set; } = String.Empty; 
    }
}
