using System;
using System.IO;
using System.Threading.Tasks;

namespace CSharpReference.HackerRank
{
    public class VeryBigSum : ICode
    {
        public int Code => 4;
        public void Execute()
        {
            TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            var arCount = Convert.ToInt32(Console.ReadLine());

            var ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            var result = aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }


        // Complete the aVeryBigSum function below.
        private static long aVeryBigSum(long[] ar)
        {
            var totalValue = 0L;
            foreach (var l in ar)
            {
                totalValue += l;
            }

            return totalValue;
        }
    }
}