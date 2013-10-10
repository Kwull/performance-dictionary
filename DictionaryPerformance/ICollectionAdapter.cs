namespace DictionaryPerformance
{
    public interface ICollectionAdapter
    {
        string Name { get; }
        string LookupMode { get; }
        void CreateAndFillTestData(int collectionSize);
        string Get(int key);
        void Dispose();
    }
}