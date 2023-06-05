using Microsoft.AspNetCore.Mvc;
using TravelProject.Data;

namespace TravelProject.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory=RouteData?.Values["id"];
            return View(CategoryRepository.Category);
        }        
    }
}