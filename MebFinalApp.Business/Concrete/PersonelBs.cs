using MebFinalApp.Business.Abstract;
using MebFinalApp.Data.Abstract;
using MebFinalApp.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MebFinalApp.Business.Concrete
{
    public class PersonelBs : IPersonelBs
    {
        private readonly IPersonelRepository repo;
        public PersonelBs(IPersonelRepository _repo)
        {
            repo = _repo;
        }
        public Personeller Delete(Personeller entity)
        {
           return repo.Delete(entity);
        }

        public Personeller Get(Expression<Func<Personeller, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Personeller> GetAll(Expression<Func<Personeller, bool>> filter, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Personeller Insert(Personeller entity)
        {
            return repo.Insert(entity);
        }

        public Personeller Update(Personeller entity)
        {
            return repo.Update(entity);
        }
    }
}
