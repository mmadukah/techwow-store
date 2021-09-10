using TechWow.Store.Core.Mappers.Abstractions;
using TechWow.Store.Core.Models;
using TechWow.Store.Repositories.EntityFramework.Models;

namespace TechWow.Store.Repositories.EntityFramework.Mappings.Abstractions
{
    public interface IEntityMapper<TSource, TDestination> : IReverseMapper<TSource, TDestination>
        where TDestination : EntityBase, new()
        where TSource : ModelBase, new()
    {
    }
}
