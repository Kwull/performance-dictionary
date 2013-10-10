using System.Collections.Generic;

namespace DictionaryPerformance.Adapters
{
    public class SortedDictionaryAdapter : CollectionAdapterBase<SortedDictionary<string, string>>
    {
        public override string LookupMode
        {
            get { return "Key"; }
        }

        protected override void Add(string key, string value)
        {
            Collection.Add(key, value);
        }

        public override string Get(string key)
        {
            return Collection[key];
        }
    }
}
