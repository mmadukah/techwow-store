using System.Collections.Generic;
using TechWow.Store.Core.Mappers.Abstractions;

namespace TechWow.Store.Core.Mappers
{
    public abstract class ReverseMapperBase<TSource, TDestination> : MapperBase<TSource, TDestination>, IReverseMapper<TSource, TDestination>
        where TDestination : new()
        where TSource : class, new()
    {
        public virtual TSource Map(TDestination source)
        {
            if (source == null)
            {
                return default;
            }

            var result = new TSource();

            Map(source, result);

            return result;
        }

        public virtual void Map(TDestination source, TSource destination)
        {
            throw new System.NotImplementedException();
        }

        public virtual IEnumerable<TSource> Map(IEnumerable<TDestination> source)
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
