using System.Collections.Generic;

namespace DictionaryPerformance.Adapters
{
    public class DictionaryAdapter : CollectionAdapterBase<Dictionary<string,string>>
    {
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
