using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Repository.Dtos;

namespace WebApi.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<List<ProductViewModel>> GetAllAsync();
        Task<ProductViewModel> GetByIdAsync(int id);
        Task<ProductViewModel> CreateAsync(ProductCreateRequest productCreateRequest);
        Task<int> UpdateAsync(ProductUpdateRequest productUpdateRequest);
        Task<int> DeleteAsync(int id);
    }
}
