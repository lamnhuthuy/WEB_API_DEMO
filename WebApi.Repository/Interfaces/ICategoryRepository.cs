using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Domain.Entities;
using WebApi.Repository.Dtos;

namespace WebApi.Repository.Interfaces
{
    public interface ICategoryRepository
    {
         Task<List<CategoryViewModel>> GetAllAsync();
         Task<CategoryViewModel> GetByIdAsync(int id);
         Task<int> CreateCategoryAsync(CategoryCreateRequest categoryCreateRequest);
         Task<int> UpdateCategoryAsync(CategoryUpdateRequest categoryUpdateRequest);
        Task<List<CategoryViewModel>> DeleteCategoryAsync(int id);
    }
}
