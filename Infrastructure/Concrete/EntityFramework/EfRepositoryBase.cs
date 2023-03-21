using Infrastructure.Abstract;
using Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Concrete.EntityFramework
{
    public class EfRepositoryBase<Entity, TContext> : IRepository<Entity>
        where Entity : AuditableEntity, IBaseDomain, new()
        where TContext : DbContext, new()
    {

        // IRepository nin talep ettiği Entity nin burada gönderilmesi gerekirken bunu sonraki katmanlarda belirlemek istiyorum. Bunun için EfRepositoryBase i de generic yaparak Entity tipini EfRepositoryBase kullanıldığı yerde gönderilmesini sağladık. 
        // Ancak generic constraintlerin burada uygulanarak IRepository nin talep ettiği tipi bire bir karşılamasını sağlamamız gerekir.
        public Entity Delete(Entity entity)
        {
            using (TContext ctx = new TContext())
            {
                ctx.Set<Entity>().Remove(entity);
                ctx.SaveChanges();
            }
            return entity;
        }
        //public Entity Delete(int Id)
        //{
        //    using (TContext ctx = new TContext())
        //    {
        //      Entity entity   ctx.Set<Entity>().Where(x=>x.Id)
        //        ctx.SaveChanges();
        //    }
        //    return entity;
        //}

        public Entity Get(Expression<Func<Entity, bool>> filter, params string[] includelist)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<Entity> query = ctx.Set<Entity>();

                if (includelist.Length>0)
                {
                    foreach (string item in includelist)
                    {
                      query=  query.Include(item);
                    }
                }
                return query.SingleOrDefault(filter);
            }
        }

        public List<Entity> GetAll(Expression<Func<Entity, bool>> filter=null, params string[] includelist)
        {


            using (TContext ctx = new TContext())
            {
                IQueryable<Entity> query = ctx.Set<Entity>();

                if (includelist.Length > 0)
                {
                    foreach (string item in includelist)
                    {
                        query = query.Include(item);
                    }
                }
                return filter == null ? query.AsNoTracking().ToList() : query.Where(filter).AsNoTracking().ToList();
            }
        }
        // .AsNoTracking() : Performans için izlemeyi kapatır.

        //public Entity GetById(int Id, params string[] includelist)
        //{
        //    throw new NotImplementedException();
        //}

        public Entity Insert(Entity entity)
        {        
            using(TContext ctx = new TContext())
            {
                ctx.Set<Entity>().Add(entity);
                ctx.SaveChanges();
                return entity;
            }
        }

        public Entity Update(Entity entity)
        {

            using (TContext ctx = new TContext())
            {
                //Entity ent = ctx.Set<Entity>().Attach(entity).Entity;
                //ctx.Entry(entity).State = EntityState.Modified;
                //ctx.SaveChanges();
                //return ent;

                ctx.Set<Entity>().Update(entity);
                ctx.SaveChanges();
                return entity;
            }
        }
    }
}
