using System;

namespace CSharpReference.Loops
{
    public class Loops : IReference
    {
        public int Code => 1;
        public string Name => "Loops";

        public void Execute()
        {
            Console.WriteLine("1 little dog");
            for (var i = 2; i <= 10; i++) Console.WriteLine($"{i} little dogs");
        }
    }
}