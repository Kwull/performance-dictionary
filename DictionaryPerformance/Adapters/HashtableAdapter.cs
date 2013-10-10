using System.Collections;

namespace DictionaryPerformance.Adapters
{
    public class HashtableAdapter : CollectionAdapterBase<Hashtable>
    {
        protected override void Add(string key, string value)
        {
            Collection.Add(key, value);
        }

        public override string Get(string key)
        {
            return Collection[key].ToString();
        }
    }
}
