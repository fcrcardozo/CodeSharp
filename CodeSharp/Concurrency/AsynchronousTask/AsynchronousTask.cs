using System;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CSharpReference.Concurrency.AsynchronousTask
{
    public class AsynchronousTask: ICode
    {
        public void Execute()
        {
            //Using only tasks has no order
            
            //Run by last
            GetSha256(new byte[100000]);
            
            
            //Run first
            GetSha256(new byte[100]);
        }

        private void GetSha256(byte[] data)
        {
            Task.Run(() =>
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