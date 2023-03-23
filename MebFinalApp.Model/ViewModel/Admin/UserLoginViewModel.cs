using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebFinalApp.Model.ViewModel.Admin
{
    public class UserLoginViewModel
    {


        //[Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz")]
        //[StringLength(12,ErrorMessage ="Lütfen 6-12 arası karakter giriniz",MinimumLength =6)]
        //[RegularExpression("",ErrorMessage ="")]
        //[Remote(action:"VerifyUsername",controller:"User")]
        public string UserName { get; set; }


        //[Required(ErrorMessage = "Lütfen Şifre Giriniz")]
        //[DataType(DataType.Password)]
        //[Url(ErrorMessage ="Lütfen url giriniz")]
        //[Compare(UserName,ErrorMessage ="")]
        //[EmailAddress(ErrorMessage ="Email formatında olmalı")]
       
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
