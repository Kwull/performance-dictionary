﻿using System.Collections.Generic;

namespace DictionaryPerformance.Adapters
{
    public class SortedSetAdapter : CollectionAdapterBase<SortedSet<string>>
    {
        public override string LookupMode
        {
            get { return "Contains(Key)"; }
        }

        protected override void Add(string key, string value)
        {
            Collection.Add(key);
        }

        public override string Get(string key)
        {
            return Collection.Contains(key).ToString();
        }
    }
}
