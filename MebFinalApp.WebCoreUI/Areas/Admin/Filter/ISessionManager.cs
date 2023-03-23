using MebFinalApp.Model.Entity;

namespace MebFinalApp.WebCoreUI.Areas.Admin.Filter
{
    public interface ISessionManager
    {
        public User AktifKullanici { get; set; }

        //public User AktifYonetici { get; set; }
    }
}
