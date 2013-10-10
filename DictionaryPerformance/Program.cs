using System;
using System.Collections.Generic;
using System.Diagnostics;
using DictionaryPerformance.Output;

namespace DictionaryPerformance
{
    class Program
    {
        private const int TestsCount = 1000000;
        private static readonly IEnumerable<int> CollectionSizes = new[] { 1000, 10000, 100000, 1000000 };

        static void Main()
        {
            IOutput output = new ConsoleOutput();
            output.Start();

            var collections = CollectionAdapterFactory.CreateAdapters();
            
            foreach (var collection in collections)
            {
                foreach (var size in CollectionSizes)
                {
                    var result = MeasurePerformance(collection, size);
                    output.RenderResult(result);
                }
            }

            output.Finish();
        }

        private static Result MeasurePerformance(ICollectionAdapter collection, int collectionSize)
        {
            CollectMemory();
            collection.CreateAndFillTestData(collectionSize);
            WarmUp(collection, collectionSize);

            var result = new Result {CollectionSize = collectionSize, Name = collection.Name};
            var beginWatch = new Stopwatch();
            var middleWatch = new Stopwatch();
            var endWatch = new Stopwatch();

            var middleKey = collectionSize/2;
            var endKey = collectionSize - 1;

            for (var i = 0; i < TestsCount; i++)
            {
                beginWatch.Start();
                var begin = collection.Get(0);
                beginWatch.Stop();

                middleWatch.Start();
                var middle = collection.Get(middleKey);
                middleWatch.Stop();

                endWatch.Start();
                var end = collection.Get(endKey);
                endWatch.Stop();
            }

            collection.Dispose();

            result.Begin = beginWatch.ElapsedMilliseconds;
            result.Middle = middleWatch.ElapsedMilliseconds;
            result.End = endWatch.ElapsedMilliseconds;

            return result;
        }

        private static void WarmUp(ICollectionAdapter collection, int collectionSize)
        {
            var middleKey = collectionSize / 2;
            var endKey = collectionSize - 1;
            var begin = collection.Get(0);
            var middle = collection.Get(middleKey);
            var end = collection.Get(endKey);
        }

        private static void CollectMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
