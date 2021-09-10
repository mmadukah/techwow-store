using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TechWow.Store.Core.Models;
using TechWow.Store.Repositories.EntityFramework.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Configuration.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Mappings.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Models;

namespace TechWow.Store.Repositories.EntityFramework
{
    public class Repository<TDomain, TEntity> : IRepository<TDomain>
        where TDomain : ModelBase, new()
        where TEntity : EntityBase, new()
    {
        protected IStoreContext Context { get; set; }
        protected IEntityMapper<TDomain, TEntity> Mapper { get; set; }

        public Repository(IStoreContext context, IEntityMapper<TDomain, TEntity> mapper)
        {
            Context = context;
            Mapper = mapper;
        }

        public virtual void Add(TDomain model)
        {
            var entity = Mapper.Map(model);

            Context.Set<TEntity>().Add(entity);
            Context.SaveChanges();
        }

        public virtual void Add(IEnumerable<TDomain> models)
        {
            foreach (var model in models)
            {
                Add(model);
            }
        }

        public virtual void Delete(int id)
        {
            var entity = Context.Set<TEntity>().AsNoTracking().FirstOrDefault(x => x.Id == id);

            if (entity == null)
            {
                return;
            }

            Context.Set<TEntity>().Remove(entity);
            Context.SaveChanges();
        }

        public virtual TDomain Get(int id)
        {
            var query = Context.Set<TEntity>() as IQueryable<TEntity>;
            var entity = query.FirstOrDefault(x => x.Id == id);
            var model = Mapper.Map(entity);

            return model;
        }

        public virtual IEnumerable<TDomain> GetAll()
        {
            var query = Context.Set<TEntity>() as IQueryable<TEntity>;
            var models = Mapper.Map(query);

            return models;
        }

        public virtual void Update(TDomain model)
        {
            var entity = Mapper.Map(model);

            Context.SaveChanges();
        }

        public virtual void Update(IEnumerable<TDomain> models)
        {
            foreach (var model in models)
            {
                Update(model);
            }
        }
    }
}
