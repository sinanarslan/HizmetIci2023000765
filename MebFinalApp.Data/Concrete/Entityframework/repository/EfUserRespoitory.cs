using Infrastructure.Concrete.EntityFramework;
using MebFinalApp.Data.Abstract;
using MebFinalApp.Data.Concrete.Entityframework.context;
using MebFinalApp.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebFinalApp.Data.Concrete.Entityframework.repository
{
    public class EfUserRespoitory:EfRepositoryBase<User,NorthwindDbContext>,IUserRepository
    {
    }
}
