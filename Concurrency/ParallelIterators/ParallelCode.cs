using System;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace CSharpReference.Concurrency.ParallelIterators
{
    public class ParallelCode: ICode
    {
        [Benchmark]
        public void Execute()
        {
            var numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Parallel.ForEach(numbers, (number, loopState) =>
            {
                Console.WriteLine("number: " + number);
            });
        }
    }
}