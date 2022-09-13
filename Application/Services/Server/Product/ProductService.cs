using Application.Interfaces.Server.Product;
using Common.ServiceResponse;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Application.Services.Server.Product
{
    public class ProductService : IProductService
{
        private readonly DataBaseContext _context;

        public ProductService(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<ResultDto<Domain.Entities.Products.Product>> GetProductAsync(int productId)
        {
            var response = new ResultDto<Domain.Entities.Products.Product>();
            //var product = await _context.Products.FindAsync(productId);

            var product = await _context.Products
                .Include(p => p.Variants)
                .ThenInclude(v => v.ProductType)
                .FirstOrDefaultAsync(p => p.Id == productId);

            if (product == null)
            {
                response.IsSuccess = false;
                response.Message = "Sorry, but this product does not exist.";
            }
            else
            {
                response.Data = product;
                response.IsSuccess = true;
            }

            return response;
        }

        public async Task<ResultDto<List<Domain.Entities.Products.Product>>> GetProductsAsync()
        {
            var Response = new ResultDto<List<Domain.Entities.Products.Product>>
            {
                //Data = await _context.Products.ToListAsync(),
                Data = await _context.Products.Include(p => p.Variants).ToListAsync(),
                IsSuccess = true
            };

            return Response;
        }

        public async Task<ResultDto<List<Domain.Entities.Products.Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ResultDto<List<Domain.Entities.Products.Product>>
            {
                Data = await _context.Products
                .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                .Include(p => p.Variants)
                .ToListAsync()
            };

            return response;
        }

        public async Task<ResultDto<List<string>>> GetProductSearchSuggestions(string searchText)
        {
            var products = await FindProductsBySearchText(searchText);

            List<string> result = new List<string>();

            foreach (var product in products)
            {
                if (product.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(product.Name);
                }

                if (product.Description != null)
                {
                    var punctuation = product.Description.Where(char.IsPunctuation)
                        .Distinct().ToArray();
                    var words = product.Description.Split()
                        .Select(s => s.Trim(punctuation));

                    foreach (var word in words)
                    {
                        if (word.Contains(searchText, StringComparison.OrdinalIgnoreCase)
                            && !result.Contains(word))
                        {
                            result.Add(word);
                        }
                    }
                }
            }

            return new ResultDto<List<string>> { Data = result };
        }

        public async Task<ResultDto<Domain.Entities.Products.ProductSearchResult>> SearchProducts(string searchText, int page)
        {
            var pageResults = 2f;
            var pageCount = Math.Ceiling((await FindProductsBySearchText(searchText)).Count / pageResults);
            var products = await _context.Products
                .Where(p => p.Name.ToLower().Contains(searchText.ToLower())
                ||
                p.Description.ToLower().Contains(searchText.ToLower()))
                .Include(p => p.Variants)
                .Skip((page - 1) * (int)pageResults)
                .Take((int)pageResults)
                .ToListAsync();

            var response = new ResultDto<Domain.Entities.Products.ProductSearchResult>
            {
                Data = new Domain.Entities.Products.ProductSearchResult
                {
                    Products = products,
                    CurrentPage = page,
                    Pages = (int)pageCount
                }
            };

            return response;
        }

        private async Task<List<Domain.Entities.Products.Product>> FindProductsBySearchText(string searchText)
        {
            return await _context.Products
                .Where(p => p.Name.ToLower().Contains(searchText.ToLower())
                ||
                p.Description.ToLower().Contains(searchText.ToLower()))
                .Include(p => p.Variants)
                .ToListAsync();
        }

        public async Task<ResultDto<List<Domain.Entities.Products.Product>>> GetFeaturedProducts()
        {
            var response = new ResultDto<List<Domain.Entities.Products.Product>>
            {
                Data = await _context.Products
                    .Where(p => p.Featured)
                    .Include(p => p.Variants)
                    .ToListAsync()
            };

            return response;
        }
    }
}
