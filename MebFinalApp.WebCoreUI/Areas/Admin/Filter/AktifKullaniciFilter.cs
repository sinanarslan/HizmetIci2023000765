using MebFinalApp.Model.Entity;
using MebFinalApp.WebCoreUI.Areas.Admin.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MebFinalApp.WebCoreUI.Areas.Admin.Filter
{
    public class AktifKullaniciFilter : ActionFilterAttribute, IActionFilter
    {
        public AktifKullaniciFilter()
        {
            
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {

            User u = context.HttpContext.Session.GetObject<User>("AktifKullanici");
            if (u == null)
            {
                context.Result = new RedirectResult("/Admin/User/Login");
            }

            base.OnActionExecuting(context);


        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}
