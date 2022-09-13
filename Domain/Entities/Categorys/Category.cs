using Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Categorys
{
    public class Category : BaseEntity
    {

        public string Name { get; set; } = String.Empty;
        public string Url { get; set; } = String.Empty;
        public virtual Category ParentCategory { get; set; }
        public int? ParentCategoryId { get; set; }

        //برای نمایش زیر دسته های هر گروه
        public virtual ICollection<Category> SubCategories { get; set; }

    }
}
