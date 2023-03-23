using MebFinalApp.Model.Entity;
using MebFinalApp.WebCoreUI.Areas.Admin.Extensions;

namespace MebFinalApp.WebCoreUI.Areas.Admin.Filter
{
    public class SessionManager : ISessionManager
    {

        public IHttpContextAccessor accessor;
        public SessionManager(IHttpContextAccessor _accessor)
        {
            accessor= _accessor;
        }

        public User AktifKullanici
        {
            get
            {
                return accessor.HttpContext.Session.GetObject<User>("AktifKullanici");
            }

            set
            {
                accessor.HttpContext.Session.SetObject("AktifKullanici", value);

            }
        }
    
    }
}
