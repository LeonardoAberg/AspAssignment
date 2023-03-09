using AspAssignment.Services;
using AspAssignment.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AspAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _productService;

        public HomeController(ProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var viewModel = new IndexViewModel
            {
                ProductModel = await _productService.GetProduct()
            };

            return View(viewModel);
        }
    }
}
