using Microsoft.AspNetCore.Mvc;
using TravelProject.Data;

namespace TravelProject.ViewComponents
{
    public class CityViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(CityRepository.City);
        } 
    }
}