namespace DictionaryPerformance.Output
{
    public interface IOutput
    {
        void Start();
        void RenderResult(Result result);
        void Finish();
    }
}