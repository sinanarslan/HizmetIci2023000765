using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MebFinalApp.Business.Abstract;
using MebFinalApp.Business.Concrete;
using MebFinalApp.Business.MappingRules;
using MebFinalApp.Model.Entity;
using MebFinalApp.Model.ViewModel.Admin;
using MebFinalApp.WebCoreUI.Areas.Admin.Extensions;
using MebFinalApp.WebCoreUI.Areas.Admin.Filter;
using MebFinalApp.WebCoreUI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient.Server;

namespace MebFinalApp.WebCoreUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {


        IUserBs userBs;
        IValidator<UserLoginViewModel> loginViewModelValidator;
        ISessionManager sessionManager;
        IMapper mapper;

        public UserController(IUserBs _userBs, IValidator<UserLoginViewModel> _loginViewModelValidator, ISessionManager _sessionManager, IMapper _mapper)
        {
            userBs = _userBs;
            loginViewModelValidator = _loginViewModelValidator;
            sessionManager = _sessionManager;
            mapper = _mapper;
        }
        public IActionResult Login()
        {
            UserLoginViewModel vm = new UserLoginViewModel();

            return View(vm);
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel vm)
        {

            ///*  ModelState.AddModelError("Nouser", "Lütfen olmayan bir kullanıcı girin"); // Server side bir algoritm*/a ile kendi validation errroumu oluşturabilirim.



            //ValidationResult result = loginViewModelValidator.Validate(vm);

            if (!ModelState.IsValid)
            {

         

                return View(vm);

            }
            else
            {

                User user = userBs.Get(x => x.UserName == vm.UserName && x.Password == vm.Password);


                // Automapper işlemi 
                UserLoginViewModel model = mapper.Map<UserLoginViewModel>(user); 




                sessionManager.AktifKullanici = user;

                return RedirectToAction("Index", "Home");
            }

            //HttpContext.Session.SetString("AktifKullanici", "Ahmet");
            //string value = HttpContext.Session.GetString("AktifKullanici");

            //10.Topla(20); // eXTENSİONmETHOD;



            //HttpContext.Session.SetObject("AktifKullanici", new User() { });

            //User user=   HttpContext.Session.GetObject<User>("AktifKullanici");


            //User user= sessionManager.AktifKullanici;


        }
    }
}
