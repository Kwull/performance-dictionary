using System;
using System.Globalization;

namespace DictionaryPerformance
{
    public abstract class CollectionAdapterBase<T> : ICollectionAdapter
        where T : class, new()
    {
        private const string KeyPrefixFormat = "SomeQuiteLongKey_SomeQuiteLongKey_{0}";

        protected T Collection { get; private set; }

        public virtual string Name
        {
            get
            {
                var name = typeof (T).Name;
                return name.Contains("`") ? name.Substring(0, name.IndexOf('`')) : name;
            }
        }

        public abstract string LookupMode { get; }

        protected abstract void Add(string key, string value);

        public abstract string Get(string key);

        public string Get(int key)
        {
            return Get(string.Format(KeyPrefixFormat, key));
        }

        public void CreateAndFillTestData(int collectionSize)
        {
            Collection = new T();
            for (var i = 0; i < collectionSize; i++)
            {
                Add(string.Format(KeyPrefixFormat, i), DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture));
            }
        }

        public virtual void Dispose()
        {
            Collection = null;
        }
    }
}
