using AspAssignment.Services;
using AspAssignment.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AspAssignment.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new IndexViewModel
            {
                ProductModel = await _productService.GetProduct()
            };

            return View(viewModel);
        }

        [Authorize(Roles = "Admin, ProductManager")]
        public IActionResult ProductAdd()
        {
            return View();
        }
    }
}
