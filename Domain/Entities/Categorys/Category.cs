using Domain.Entities.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Categorys
{
    public class Category : BaseEntity
    {

        public string Name { get; set; } = String.Empty;
        public string Url { get; set; } = String.Empty;
        public virtual Category ParentCategory { get; set; }
        public int? ParentCategoryId { get; set; }
        public bool IsVisible { get; set; } = true;
        [NotMapped]
        public bool IsEditing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;

        //برای نمایش زیر دسته های هر گروه
        public virtual ICollection<Category> SubCategories { get; set; }

    }
}
