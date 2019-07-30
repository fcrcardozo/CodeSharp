namespace CSharpReference
{
    
    public interface IReference
    {
        int Code { get; }
        string Name { get; }
        void Execute();
    }
}