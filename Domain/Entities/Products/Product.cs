using Domain.Entities.Categorys;
using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Products
{
    public class Product : BaseEntity
    {

        public string Name { get; set; } = String.Empty;
        public string Brand { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int? Inventory { get; set; }
        public bool Displayed { get; set; }
        public int? ViewCount { get; set; }

        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>();

        //برای مشخص کردن دسته بندی هر محصول
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }

        //برای مشخص کردن عکس های هر محصول
        //public virtual ICollection<ProductImages> ProductImages { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        //برای مشخص کردن ویژگی های هر محصول
        //public virtual ICollection<ProductFeatures> ProductFeatures { get; set; }
        public bool Featured { get; set; } = false;

    }
}
