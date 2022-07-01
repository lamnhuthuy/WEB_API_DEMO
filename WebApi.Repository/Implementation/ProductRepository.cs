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
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ProductViewModel> CreateAsync(ProductCreateRequest productCreateRequest)
        {
            var product = new Product() 
            {
                Name = productCreateRequest.Name,
                Size = productCreateRequest.Size,
                CategoryId = productCreateRequest.CategoryId,
                DateCreated = productCreateRequest.DateCreated,
                Description = productCreateRequest.Description,
                Price = productCreateRequest.Price,

            };
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return new ProductViewModel() 
            {
                Id = product.Id,
                Name = product.Name,
                Size = product.Size,
                CategoryId = product.CategoryId,
                DateCreated = product.DateCreated,
                Description = product.Description,
                Price = product.Price,
            };



        }

        public async Task<int> DeleteAsync(int id)
        {
           var product =await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
            if(product== null)
            {
                throw new AppException($"Can't find product with id={id}");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ProductViewModel>> GetAllAsync()
        {
           var data=new List<ProductViewModel>();
            data = await _context.Products.Include(item => item.Category).Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CategoryName=x.Category.Name,
                Price = x.Price,
                DateCreated=x.DateCreated,
                CategoryId=x.CategoryId,
                Size=x.Size,

            }).ToListAsync();
            return data;

        }

        public async Task<ProductViewModel> GetByIdAsync(int id)
        {
            var product = await _context.Products.Include(x=> x.Category).Where(x => x.Id == id).SingleOrDefaultAsync();
            if (product == null)
            {
                throw new AppException($"Can't find product with id={id}");
            }
            return new ProductViewModel
            {

                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                CategoryName = product.Category.Name,
                Price = product.Price,
                DateCreated = product.DateCreated,
                CategoryId = product.CategoryId,
                Size = product.Size,
            };

        }

        public async Task<int> UpdateAsync(ProductUpdateRequest productUpdateRequest)
        {
            var product = await _context.Products.FindAsync(productUpdateRequest.Id);
            if(product== null)
            {
                throw new AppException($"Can't find product with id={productUpdateRequest.Id}");
            }
            product.DateCreated = productUpdateRequest.DateCreated;
            product.CategoryId = productUpdateRequest.CategoryId;
            product.Size = productUpdateRequest.Size;
            product.Price = productUpdateRequest.Price; 
            product.Name = productUpdateRequest.Name;
            product.Description = productUpdateRequest.Description;
            return await _context.SaveChangesAsync();
               
        }
    }
}
