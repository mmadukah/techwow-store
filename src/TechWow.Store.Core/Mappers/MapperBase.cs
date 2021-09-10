using System.Collections.Generic;
using TechWow.Store.Core.Mappers.Abstractions;

namespace TechWow.Store.Core.Mappers
{
    public abstract class MapperBase<TSource, TDestination> : IMapper<TSource, TDestination>
        where TDestination : new()
        where TSource: class 
    {
        public virtual TDestination Map(TSource source)
        {
            if (source == null)
            {
                return default;
            }

            var result = new TDestination();

            Map(source, result);

            return result;
        }

        public abstract void Map(TSource source, TDestination destination);

        public virtual IEnumerable<TDestination> Map(IEnumerable<TSource> source)
        {
            if (source == null)
            {
                yield break;
            }

            foreach (var item in source)
            {
                if (item == null)
                {
                    continue;
                }

                yield return Map(item);
            }
        }
    }
}
