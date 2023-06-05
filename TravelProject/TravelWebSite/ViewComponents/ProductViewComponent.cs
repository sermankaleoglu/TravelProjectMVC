using Microsoft.AspNetCore.Mvc;
using TravelProject.Data;

namespace TravelProject.ViewComponents
{
    public class ProductViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(ProductRepository.Product);
        }        
    }
}