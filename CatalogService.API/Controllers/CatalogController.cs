using CatalogService.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatalogService.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly IProductAppService _productAppService;
        public CatalogController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productAppService.GetAll();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

       [HttpGet]
        public IActionResult GetProductById(int id)
        {
            try
            {
                var product = _productAppService.GetById(id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }

       
        [HttpPost]
        public IActionResult GetProductsByIds([FromBody] int[] ids)
        {
            try
            {
                var products = _productAppService.GetByIds(ids);
                if (products == null)
                {
                    return NotFound();
                }
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
            }
        }
    }
}
