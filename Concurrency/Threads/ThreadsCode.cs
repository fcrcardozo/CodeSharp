using System;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;

namespace CSharpReference.Concurrency.Threads
{
    public class ThreadsCode : ICode
    {
        public async void Execute()
        {
            //Using await has order

            //Run first
            var bigCode = new Action(() => GetSha256(new byte[10000000]));
            var firstThreadStarted = new ThreadStart(bigCode);
            new Thread(firstThreadStarted).Start();


            //Run second
            var smallCode = new Action(() => GetSha256(new byte[100]));
            var secondThreadStarted = new ThreadStart(smallCode);
            new Thread(secondThreadStarted).Start();
        }

        private static void GetSha256(byte[] data)
        {
            var sha256 = new SHA256Managed();
            var retval = sha256.ComputeHash(data);
            var hash = retval.Aggregate(string.Empty, (current, theByte) => current + theByte.ToString("x2"));

            Console.WriteLine(hash);
            Console.WriteLine(data.Length);
        }
    }
}