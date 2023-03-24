using MebFinalApp.Business.Abstract;
using MebFinalApp.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MebFinalApp.WebCoreUI.Areas.Admin.Controllers
{



    [Area("Admin")]
    public class ProductController : Controller
    {
        IUrunBs _urunBs;
        public ProductController(IUrunBs urunBs)
        {
            _urunBs = urunBs;
        }

        public IActionResult Index()
        {


            List<Urunler> model = _urunBs.GetAll(null);


            return View(model);
        }
    }
}
