using TechWow.Store.Core.Mappers.Abstractions;
using TechWow.Store.Core.Models;

namespace TechWow.Store.Web.Mappings.Abstractions
{
    public interface IModelMapper<TSource, TDestination> : IReverseMapper<TSource, TDestination>
        where TDestination : class, new()
        where TSource : ModelBase, new()
    {
    }
}
