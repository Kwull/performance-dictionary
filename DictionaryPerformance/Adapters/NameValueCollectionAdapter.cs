using System.Collections.Specialized;

namespace DictionaryPerformance.Adapters
{
    public class NameValueCollectionAdapter : CollectionAdapterBase<NameValueCollection>
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
