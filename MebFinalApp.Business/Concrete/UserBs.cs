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
    public class UserBs : IUserBs
    {

        private readonly IUserRepository repo;
        public UserBs(IUserRepository _repo)
        {
            repo = _repo;
        }
        public User Delete(User entity)
        {
          return  repo.Delete(entity);
        }

        public User Get(Expression<Func<User, bool>> filter, params string[] includelist)
        {
            return repo.Get(filter, includelist);
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter, params string[] includelist)
        {
            return repo.GetAll(filter, includelist);
        }

        public User Insert(User entity)
        {
            return repo.Insert(entity);
        }

        public User Update(User entity)
        {
            return repo.Update(entity);
        }
    }
}
