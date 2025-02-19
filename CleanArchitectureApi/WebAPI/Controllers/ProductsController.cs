using Microsoft.AspNetCore.Mvc;
using ApplicationCore.Interfaces;
using Infrastructure.Adapters;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IJsonConverter _jsonConverter;

        public ProductsController(IProductRepository productRepository, IJsonConverter jsonConverter)
        {
            _productRepository = productRepository;
            _jsonConverter = jsonConverter;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productRepository.GetProducts();
            var json = _jsonConverter.ConvertToJson(products);
            return Ok(json);
        }
    }
}