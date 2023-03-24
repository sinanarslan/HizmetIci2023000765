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
    public class UrunBs:IUrunBs
    {
        private readonly IUrunRepository repo;
        public UrunBs(IUrunRepository _repo)
        {
            repo = _repo;
        }
        public Urunler Delete(Urunler entity)
        {
            return repo.Delete(entity);
        }

        public Urunler Get(Expression<Func<Urunler, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<Urunler> GetAll(Expression<Func<Urunler, bool>> filter, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public Urunler Insert(Urunler entity)
        {
            return repo.Insert(entity);
        }

        public Urunler Update(Urunler entity)
        {
            return repo.Update(entity);
        }
    }
}
