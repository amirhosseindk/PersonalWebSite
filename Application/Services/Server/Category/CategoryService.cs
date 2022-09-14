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

        public async Task<ResultDto<List<Domain.Entities.Categorys.Category>>> AddCategory(Domain.Entities.Categorys.Category category)
        {
            category.IsEditing = category.IsNew = false;
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return await GetAdminCategories();
        }

        public async Task<ResultDto<List<Domain.Entities.Categorys.Category>>> DeleteCategory(int id)
        {
            Domain.Entities.Categorys.Category category = await GetCategoryById(id);
            if (category == null)
            {
                return new ResultDto<List<Domain.Entities.Categorys.Category>>
                {
                    IsSuccess = false,
                    Message = "Category not found."
                };
            }

            category.IsRemoved = true;
            await _context.SaveChangesAsync();

            return await GetAdminCategories();
        }

        private async Task<Domain.Entities.Categorys.Category> GetCategoryById(int id)
        {
            return await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<ResultDto<List<Domain.Entities.Categorys.Category>>> GetAdminCategories()
        {
            var categories = await _context.Categories
                .Where(c => !c.IsRemoved)
                .ToListAsync();
            return new ResultDto<List<Domain.Entities.Categorys.Category>>
            {
                Data = categories,
                IsSuccess = true,
                Message = "success"
            };
        }


        public async Task<ResultDto<List<Domain.Entities.Categorys.Category>>> GetCategories()
        {
            var categories = await _context.Categories
                .Where(c => !c.IsRemoved && c.IsVisible)
                .ToListAsync();
            return new ResultDto<List<Domain.Entities.Categorys.Category>>
            {
                Data = categories,
                IsSuccess = true,
                Message = "success"
            };
        }

        public async Task<ResultDto<List<Domain.Entities.Categorys.Category>>> UpdateCategory(Domain.Entities.Categorys.Category category)
        {
            var dbCategory = await GetCategoryById(category.Id);
            if (dbCategory == null)
            {
                return new ResultDto<List<Domain.Entities.Categorys.Category>>
                {
                    IsSuccess = false,
                    Message = "Category not found."
                };
            }

            dbCategory.Name = category.Name;
            dbCategory.Url = category.Url;
            dbCategory.IsVisible = category.IsVisible;

            await _context.SaveChangesAsync();

            return await GetAdminCategories();

        }
    }
}
