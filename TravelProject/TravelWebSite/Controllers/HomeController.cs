using Microsoft.AspNetCore.Mvc;
using TravelProject.Data;
using TravelProject.ViewModels;

namespace TravelProject.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult index(int id)
        {
            var products=ProductRepository.Product;
            if(id==1)
            {
                products = products.ToList();
            }
            else if(id!=null)
            {
                products=products.Where(p=>p.CategoryId==id).ToList();
            }

            var ProductViewModel = new ProductViewModel()
            {
                Products = products
            };
            return View(ProductViewModel);
        }
        public IActionResult about()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }
    }
}