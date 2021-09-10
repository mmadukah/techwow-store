using Mapster;
using TechWow.Store.Core.Mappers;
using TechWow.Store.Web.Mappings.Abstractions;

namespace TechWow.Store.Web.Mappings
{
    public class ModelMapperBase<TSource, TDestination> : ReverseMapperBase<TSource, TDestination>, IModelMapper<TSource, TDestination>
        where TDestination : class, new()
        where TSource : Core.Models.ModelBase, new()
    {
        public override void Map(TSource source, TDestination destination)
        {
            source.Adapt(destination);
        }

        public override void Map(TDestination source, TSource destination)
        {
            source.Adapt(destination);
        }
    }
}
