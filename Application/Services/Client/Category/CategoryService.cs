using Application.Interfaces.Client.Category;
using Common.ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

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
    }
}
