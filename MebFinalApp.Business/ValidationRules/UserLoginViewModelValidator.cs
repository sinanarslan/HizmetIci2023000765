using FluentValidation;
using MebFinalApp.Business.Abstract;
using MebFinalApp.Business.Concrete;
using MebFinalApp.Model.Entity;
using MebFinalApp.Model.ViewModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebFinalApp.Business.ValidationRules
{
    public class UserLoginViewModelValidator:AbstractValidator<UserLoginViewModel>
    {
        IUserBs userBs;


        public UserLoginViewModelValidator(IUserBs _userBs)
        {
            userBs = _userBs;

            RuleFor(x => x.UserName).NotEmpty().WithMessage("Lütfen Boş Bırakmayınız").MaximumLength(10).WithMessage("Lütfen 10 karakterden az giriniz");

            //RuleFor(x => x.UserName).Must(KullaniciAdiKontrol).WithMessage("Bu Kullanıcı Adı Kullanılıyor");


        }

        private bool KullaniciAdiKontrol(string arg)
        {
           User user= userBs.Get(x => x.UserName == arg);

            if (user==null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
