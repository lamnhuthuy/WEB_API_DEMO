using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Repository.Dtos;
using WebApi.Repository.Interfaces;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _productRepository.GetAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            try
            {
                var data = await _productRepository.GetByIdAsync(id);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }          
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] ProductCreateRequest productCreateRequest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var product = await _productRepository.CreateAsync(productCreateRequest);
                    
                return Ok(product);
            }
            catch (Exception ex)
            {
              return  BadRequest(ex.Message);
            }               
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] ProductUpdateRequest productUpdateRequest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _productRepository.UpdateAsync(productUpdateRequest);

                if (result == 0)
                {
                    return BadRequest();
                }

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{id}")]
         public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                var result = await _productRepository.DeleteAsync(id);
                if (result == null)
                {
                    return BadRequest(result);
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
         

        }
    }
}
