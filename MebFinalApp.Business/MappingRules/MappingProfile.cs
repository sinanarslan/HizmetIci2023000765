using AutoMapper;
using MebFinalApp.Model.Entity;
using MebFinalApp.Model.ViewModel.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebFinalApp.Business.MappingRules
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {            // Source      // Destination          Destionation     // Source
            CreateMap<User, UserLoginViewModel>();
                
                //. ForMember(x=>x.UserName,y=>y.MapFrom(k=>k.UserName)) 
                // Eğer Entity ile ViewModel arasındaki property ler birbirinden farklı ise eşleştirmek için kullanılır
            CreateMap<UserLoginViewModel, User>();


        }


    }
}
