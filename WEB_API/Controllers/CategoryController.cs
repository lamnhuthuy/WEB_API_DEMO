using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApi.Repository.Dtos;
using WebApi.Repository.Interfaces;

namespace WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data= await _categoryRepository.GetAllAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            try
            {
                var category = await _categoryRepository.GetByIdAsync(id);
                return Ok(category);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }         
        }
        [HttpPost]
        public async Task<IActionResult>CreateAsync([FromBody]CategoryCreateRequest categoryCreateRequest)
        {        
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var categoryId = await _categoryRepository.CreateCategoryAsync(categoryCreateRequest);
                if (categoryId == 0)
                {
                    return BadRequest();
                }
                var category= await _categoryRepository.GetByIdAsync(categoryId);
                return Ok(category);
            }
            catch (Exception ex)
            {
              return  BadRequest(ex.Message);
            }                                    
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] CategoryUpdateRequest categoryUpdateRequest)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var result = await _categoryRepository.UpdateCategoryAsync(categoryUpdateRequest);

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
                var result = await _categoryRepository.DeleteCategoryAsync(id);
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
