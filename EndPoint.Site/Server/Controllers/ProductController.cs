namespace EndPoint.Site.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            var result = await _service.GetProductsAsync();
            return Ok(result);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ResultDto<Product>>> GetProduct(int productId)
        {
            var result = await _service.GetProductAsync(productId);
            return Ok(result);
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ResultDto<List<Product>>>> GetProductsByCategory(string categoryUrl)
        {
            var result = await _service.GetProductsByCategory(categoryUrl);
            return Ok(result);
        }

        [HttpGet("search/{searchText}/{page}")]
        public async Task<ActionResult<ResultDto<ProductSearchResult>>> SearchProducts(string searchText, int page=1)
        {
            var result = await _service.SearchProducts(searchText,page);
            return Ok(result);
        }

        [HttpGet("searchsuggestions/{searchText}")]
        public async Task<ActionResult<ResultDto<List<Product>>>> GetProductSearchSuggestions(string searchText)
        {
            var result = await _service.GetProductSearchSuggestions(searchText);
            return Ok(result);
        }

        [HttpGet("featured")]
        public async Task<ActionResult<ResultDto<List<Product>>>> GetFeaturedProducts()
        {
            var result = await _service.GetFeaturedProducts();
            return Ok(result);
        }

    }
}
