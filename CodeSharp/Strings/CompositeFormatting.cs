using System;

namespace CSharpReference.Strings
{
    public class CompositeFormatting: ICode
    {
        public void Execute()
        {
            Console.WriteLine("Time {0:t}! date {0:d}, Temp {1:N2} now.", DateTime.Now, 42.0);
        }
    }
}