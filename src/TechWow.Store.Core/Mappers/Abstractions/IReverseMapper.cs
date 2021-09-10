using System.Collections.Generic;

namespace TechWow.Store.Core.Mappers.Abstractions
{
    public interface IReverseMapper<TSource, TDestination> : IMapper<TSource, TDestination>
    {
        TSource Map(TDestination source);
        void Map(TDestination source, TSource destination);
        IEnumerable<TSource> Map(IEnumerable<TDestination> source);
    }
}
