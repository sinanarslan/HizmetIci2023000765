using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MebFinalApp.Business.Abstract
{
    public interface IBusinessBase<TEntity>
        where TEntity : AuditableEntity,IBaseDomain
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter, params string[] includelist);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includelist);

        //TEntity GetById(int Id, params string[] includelist);



        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);

    }
}
