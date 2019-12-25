using System;
using System.Threading.Tasks;

namespace CSharpReference.Loops
{
    public class Loops : ICode
    {
        public int Code => 1;

        public void Execute()
        {
            Console.WriteLine("1 little dog");
            for (var i = 2; i <= 10; i++) Console.WriteLine($"{i} little dogs");
        }
    }
}