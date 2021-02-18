using System;

namespace CSharpReference.Strings
{
    public class Interpolation : ICode
    {
        public void Execute()
        {
            Console.WriteLine(@$"{DateTime.Now:HH:mm}");
        }
    }
}