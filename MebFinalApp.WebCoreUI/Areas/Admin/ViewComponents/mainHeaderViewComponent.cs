using Microsoft.AspNetCore.Mvc;

namespace MebFinalApp.WebCoreUI.Areas.Admin.ViewComponents
{
    public class mainHeaderViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {


            return View();
        }
    }
}
