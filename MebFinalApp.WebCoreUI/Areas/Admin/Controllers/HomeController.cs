using MebFinalApp.WebCoreUI.Areas.Admin.Filter;
using Microsoft.AspNetCore.Mvc;

namespace MebFinalApp.WebCoreUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    [AktifKullaniciFilter]
    public class HomeController : Controller
    {

    

       
        public IActionResult Index()
        {



            return View();
        }
    }
}
