using System.Collections.Generic;

namespace TechWow.Store.Core.Mappers.Abstractions
{
    public interface IMapper<TSource, TDestination>
    {
        TDestination Map(TSource source);
        void Map(TSource source, TDestination destination);
        IEnumerable<TDestination> Map(IEnumerable<TSource> source);
    }
}
