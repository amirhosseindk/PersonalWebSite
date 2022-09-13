using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Client.Category
{
    public interface ICategoryService
    {
        List<Domain.Entities.Categorys.Category> Categories { get; set; }
        Task GetCategories();
    }
}
