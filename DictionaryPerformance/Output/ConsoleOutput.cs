using System;

namespace DictionaryPerformance.Output
{
    public class ConsoleOutput : IOutput
    {
        public void Start()
        {
            Console.WriteLine("Note: Please run the test in Release mode outside Visual Studio");
            Console.WriteLine();
            Console.WriteLine("Name                \tLookup         \tSize\t\tBegin\t\tMiddle\t\tEnd");
        }

        public void RenderResult(Result result)
        {
            Console.WriteLine("{0,-20}\t{1,-15}\t{2}\t\t{3}\t\t{4}\t\t{5}",
                              result.Name,
                              result.LookupMode,
                              result.CollectionSize,
                              result.Begin,
                              result.Middle,
                              result.End
                );
        }

        public void Finish()
        {
            Console.WriteLine();
            Console.WriteLine("Done. Press a key to exit");
            Console.ReadKey();
        }
    }
}
