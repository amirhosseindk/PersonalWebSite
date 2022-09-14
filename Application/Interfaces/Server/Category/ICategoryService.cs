using Common.ServiceResponse;

namespace Application.Interfaces.Server.Category
{
    public interface ICategoryService
    {
        Task<ResultDto<List<Domain.Entities.Categorys.Category>>> GetCategories();
        Task<ResultDto<List<Domain.Entities.Categorys.Category>>> GetAdminCategories();
        Task<ResultDto<List<Domain.Entities.Categorys.Category>>> AddCategory(Domain.Entities.Categorys.Category category);
        Task<ResultDto<List<Domain.Entities.Categorys.Category>>> UpdateCategory(Domain.Entities.Categorys.Category category);
        Task<ResultDto<List<Domain.Entities.Categorys.Category>>> DeleteCategory(int id);
    }
}
