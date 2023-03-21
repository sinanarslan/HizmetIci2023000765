using Infrastructure.Concrete.EntityFramework;
using MebFinalApp.Data.Abstract;
using MebFinalApp.Data.Concrete.Entityframework.context;
using MebFinalApp.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebFinalApp.Data.Concrete.Entityframework.repository
{
    public class EfPersonelRepository : EfRepositoryBase<Personeller, NorthwindDbContext>, IPersonelRepository
    {
        public int PersonelinYillaraGoreSatisSayisi(int yil)
        {

            //NorthwindDbContext context = new NorthwindDbContext();
            //var id = context.Database.ExecuteSqlRaw("select", "");

            //context.Personellers.FromSqlRaw();

            return 5;


        }
    }
}
