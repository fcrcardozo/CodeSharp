using System;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using CSharpReference;

namespace CodeSharp.Concurrency.BackgroundWorkers
{
    public class ParallelCode : ICode
    {
        [Benchmark]
        public void Execute()
        {
            var nubers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Parallel.ForEach(nubers, (number, loopState) =>
            {
                Console.WriteLine("number: " + number);
            });
        }
    }
}