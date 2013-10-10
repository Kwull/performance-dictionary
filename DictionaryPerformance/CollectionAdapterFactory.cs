using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryPerformance
{
    public class CollectionAdapterFactory
    {
        public static IEnumerable<ICollectionAdapter> CreateAdapters()
        {
            return typeof(CollectionAdapterFactory).Assembly.GetTypes()
                 .Where(t => t.IsClass && !t.IsAbstract && t.GetInterfaces().Contains(typeof(ICollectionAdapter)))
                 .Select(Activator.CreateInstance)
                 .Cast<ICollectionAdapter>()
                 .OrderByDescending(c=>c.LookupMode).ThenBy(c=>c.Name);
        }
    }
}