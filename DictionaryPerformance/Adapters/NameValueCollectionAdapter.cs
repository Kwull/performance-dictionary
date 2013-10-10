using System.Collections.Specialized;

namespace DictionaryPerformance.Adapters
{
    public class NameValueCollectionAdapter : CollectionAdapterBase<NameValueCollection>
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
