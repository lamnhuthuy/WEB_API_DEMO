using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;
using WebApi.Persistence;
using WebApi.Repository.Dtos;
using WebApi.Repository.Interfaces;

namespace WebApi.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

       
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateCategoryAsync(CategoryCreateRequest categoryCreateRequest)
        {
            var data = new Category()
            {
             Name= categoryCreateRequest.Name,
             Description= categoryCreateRequest.Description,
            };          
                await _context.Categories.AddAsync(data);
                await _context.SaveChangesAsync();
                return data.Id;          
        }

        public async Task<List<CategoryViewModel>> DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.Where(x=>x.Id==id).FirstOrDefaultAsync();
            if (category == null)
            {
                throw new AppException($"Can't find Category with id={id}");
            }        
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return await  this.GetAllAsync();

        }

        public async Task<List<CategoryViewModel>> GetAllAsync()
        {
           var data = new List<CategoryViewModel>();
           data =await _context.Categories.Select(item => new CategoryViewModel() { 
            
                Name = item.Name,
                Id = item.Id,
                Description = item.Description,
            }).ToListAsync();

            return data;        
        }

        public async Task<CategoryViewModel> GetByIdAsync(int id)
        {
            var category = await _context.Categories.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (category == null)
            {
                throw new AppException($"Can't find Category with id={id}");
            }
            return new CategoryViewModel()
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
            };
        }

        public async Task<int> UpdateCategoryAsync(CategoryUpdateRequest categoryUpdateRequest)
        {
            var category = await _context.Categories.FindAsync(categoryUpdateRequest.Id);
            if(category== null)
            {
                throw new AppException($"Can't find Category with id={categoryUpdateRequest.Id}");
            }
            category.Name = categoryUpdateRequest.Name;
            category.Description = categoryUpdateRequest.Description;
            return await _context.SaveChangesAsync();
        }
    }
}
