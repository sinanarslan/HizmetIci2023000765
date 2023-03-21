using Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Abstract
{
    public interface IRepository<TEntity>
        where TEntity : AuditableEntity, IBaseDomain,new()
    {
        //Expression<Func<TEntity, bool>>   :=> lamda nın tipidir
        List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter, params string[] includelist);
        TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includelist);

        //TEntity GetById(int Id, params string[] includelist);

        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        //TEntity Delete(int Id);


    }
}
