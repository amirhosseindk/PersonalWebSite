using Application.Interfaces.Client.Category;
using Common.ServiceResponse;
using System.Net.Http.Json;

namespace Application.Services.Client.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public List<Domain.Entities.Categorys.Category> Categories { get; set; } = new List<Domain.Entities.Categorys.Category>();

        public async Task GetCategories()
        {
            var response = await _http.GetFromJsonAsync<ResultDto<List<Domain.Entities.Categorys.Category>>>("api/Category");
            if (response != null && response.Data != null)
                Categories = response.Data;
        }
        public List<Domain.Entities.Categorys.Category> AdminCategories { get; set; } = new List<Domain.Entities.Categorys.Category>();

        public event Action OnChange;

        public async Task AddCategory(Domain.Entities.Categorys.Category category)
        {
            var response = await _http.PostAsJsonAsync("api/Category/admin", category);
            AdminCategories = (await response.Content
                .ReadFromJsonAsync<ResultDto<List<Domain.Entities.Categorys.Category>>>()).Data;
            await GetCategories();
            OnChange.Invoke();
        }

        public Domain.Entities.Categorys.Category CreateNewCategory()
        {
            var newCategory = new Domain.Entities.Categorys.Category { IsNew = true, IsEditing = true };
            AdminCategories.Add(newCategory);
            OnChange.Invoke();
            return newCategory;
        }

        public async Task DeleteCategory(int categoryId)
        {
            var response = await _http.DeleteAsync($"api/Category/admin/{categoryId}");
            AdminCategories = (await response.Content
                .ReadFromJsonAsync<ResultDto<List<Domain.Entities.Categorys.Category>>>()).Data;
            await GetCategories();
            OnChange.Invoke();
        }

        public async Task GetAdminCategories()
        {
            var response = await _http.GetFromJsonAsync<ResultDto<List<Domain.Entities.Categorys.Category>>>("api/Category/admin");
            if (response != null && response.Data != null)
                AdminCategories = response.Data;
        }

        public async Task UpdateCategory(Domain.Entities.Categorys.Category category)
        {
            var response = await _http.PutAsJsonAsync("api/Category/admin", category);
            AdminCategories = (await response.Content
                .ReadFromJsonAsync<ResultDto<List<Domain.Entities.Categorys.Category>>>()).Data;
            await GetCategories();
            OnChange.Invoke();
        }
    }
}
