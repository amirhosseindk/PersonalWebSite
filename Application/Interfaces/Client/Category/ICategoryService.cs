namespace Application.Interfaces.Client.Category
{
    public interface ICategoryService
    {
        event Action OnChange;
        List<Domain.Entities.Categorys.Category> Categories { get; set; }
        Task GetCategories();
        Task GetAdminCategories();
        Task AddCategory(Domain.Entities.Categorys.Category category);
        Task UpdateCategory(Domain.Entities.Categorys.Category category);
        Task DeleteCategory(int categoryId);
        Domain.Entities.Categorys.Category CreateNewCategory();
        List<Domain.Entities.Categorys.Category> AdminCategories { get; set; }
    }
}
