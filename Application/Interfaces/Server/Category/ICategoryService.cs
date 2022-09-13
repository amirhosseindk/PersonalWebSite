using Common.ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Server.Category
{
    public interface ICategoryService
    {
        Task<ResultDto<List<Domain.Entities.Categorys.Category>>> GetCategories();
    }
}
