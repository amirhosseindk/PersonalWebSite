using Application.Interfaces.Server.Category;
using Common.ServiceResponse;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Application.Services.Server.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly DataBaseContext _context;

        public CategoryService(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<ResultDto<List<Domain.Entities.Categorys.Category>>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return new ResultDto<List<Domain.Entities.Categorys.Category>>
            {
                Data = categories
            };
        }
    }
}
