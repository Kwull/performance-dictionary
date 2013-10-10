using System.Collections.Concurrent;

namespace DictionaryPerformance.Adapters
{
    public class ConcurrentDictionaryAdapter : CollectionAdapterBase<ConcurrentDictionary<string,string>>
    {
        protected override void Add(string key, string value)
        {
            Collection.AddOrUpdate(key, s => value, (s, s1) => value);
        }

        public override string Get(string key)
        {
            return Collection[key];
        }
    }
}
