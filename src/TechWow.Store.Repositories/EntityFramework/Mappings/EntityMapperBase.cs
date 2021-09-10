using Mapster;
using TechWow.Store.Core.Mappers;
using TechWow.Store.Core.Models;
using TechWow.Store.Repositories.EntityFramework.Mappings.Abstractions;
using TechWow.Store.Repositories.EntityFramework.Models;

namespace TechWow.Store.Repositories.EntityFramework.Mappings
{
    public class EntityMapperBase<TSource, TDestination> : ReverseMapperBase<TSource, TDestination>, IEntityMapper<TSource, TDestination>
        where TDestination : EntityBase, new()
        where TSource : ModelBase, new()
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
