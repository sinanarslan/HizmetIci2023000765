using Microsoft.AspNetCore.Mvc;

namespace MebFinalApp.WebCoreUI.Areas.Admin.ViewComponents
{
    public class sidebarViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {


            return View();
        }
    }
}
