namespace DictionaryPerformance
{
    public interface ICollectionAdapter
    {
        string Name { get; }
        void CreateAndFillTestData(int collectionSize);
        string Get(int key);
        void Dispose();
    }
}