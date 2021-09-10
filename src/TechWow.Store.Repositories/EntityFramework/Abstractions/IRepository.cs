using System.Collections.Generic;
using TechWow.Store.Core.Models;

namespace TechWow.Store.Repositories.EntityFramework.Abstractions
{
    public interface IRepository<TDomain> where TDomain : ModelBase
    {
        void Add(TDomain model);
        void Add(IEnumerable<TDomain> models);
        void Delete(int id);
        TDomain Get(int id);
        IEnumerable<TDomain> GetAll();
        void Update(TDomain model);
        void Update(IEnumerable<TDomain> models);
    }
}
