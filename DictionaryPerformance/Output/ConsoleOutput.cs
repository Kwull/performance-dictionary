using System;

namespace DictionaryPerformance.Output
{
    public class ConsoleOutput : IOutput
    {
        public void Start()
        {
            Console.WriteLine("Note: Please run the test in Release mode outside Visual Studio");
            Console.WriteLine();
            Console.WriteLine("Name                \tSize\t\tBegin\t\tMiddle\t\tEnd");
        }

        public void RenderResult(Result result)
        {
            Console.WriteLine("{0,-20}\t{1}\t\t{2}\t\t{3}\t\t{4}",
                              result.Name,
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
