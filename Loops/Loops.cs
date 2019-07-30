using System;

namespace CSharpReference.Loops
{
    
    
    public class Loops: IReference
    {
        public int Code => 1;
        public string Name => "Loops";

        public void Execute()
        {
            Console.WriteLine("Teste");
        }
    }
}