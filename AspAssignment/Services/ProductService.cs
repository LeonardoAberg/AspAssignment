using AspAssignment.Contexts;
using AspAssignment.Models;
using Microsoft.EntityFrameworkCore;

namespace AspAssignment.Services
{
    public class ProductService
    {
        private readonly DataContext _context;

        public ProductService(DataContext context)
        {
            _context = context;
        }

        public async Task<ProductModel> GetProduct()
        {
            var productModel = await _context.Products.FirstOrDefaultAsync();

            return new ProductModel
            {
                SKU = productModel!.SKU,
                Name = productModel.Name,
                Description = productModel.Description,
                Price = productModel.Price
            };
        }
    }
}
