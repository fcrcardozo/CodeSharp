using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using CSharpReference.Concurrency.ParallelIterators;

namespace CSharpReference.Concurrency.AsyncAndAwait
{
    public class AsyncAndAwait : ICode
    {
        public async void Execute()
        {
            //Using await has order

            //Run first
            await GetSha256(new byte[100000]);


            //Run second
            await GetSha256(new byte[100]);
        }

        private Task GetSha256(byte[] data)
        {
            return Task.Run(() =>
            {
                var sha256 = new SHA256Managed();
                var retval = sha256.ComputeHash(data);
                var hash = retval.Aggregate(string.Empty, (current, theByte) => current + theByte.ToString("x2"));

                Console.WriteLine(hash);
                Console.WriteLine(data.Length);
            });
        }
    }
}