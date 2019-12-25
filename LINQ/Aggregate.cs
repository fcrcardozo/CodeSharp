using System;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpReference.LINQ
{
    public class Aggregate: ICode
    {
        public int Code => 5;
        public void Execute()
        {
            var result = new[]{1,2,3,4,5}.Aggregate((a,b) => a + b);
            
            Console.WriteLine(result);
        }
    }
}