using Infrastructure.Abstract;
using MebFinalApp.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MebFinalApp.Data.Abstract
{
    public interface IPersonelRepository:IRepository<Personeller>
    {

        int PersonelinYillaraGoreSatisSayisi(int yil);

    }
}
