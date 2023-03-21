using MebFinalApp.Business.Abstract;
using MebFinalApp.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace MebFinalApp.WebCoreUI.Controllers
{
    public class PersonelController : Controller
    {
        IPersonelBs personelBs;
        public PersonelController(IPersonelBs _personelBs)
        {
            personelBs = _personelBs;
        }

        public IActionResult Index()
        {
           List<Personeller> personellers = personelBs.GetAll(x => x.PersonelId > 4, "Satislars");

            return View(personellers);
        }
    }
}
