using System;
using System.Linq;
using BenchmarkDotNet.Running;

namespace CSharpReference
{
    public interface ICode
    {
        void Execute();

        string Name => this.GetType().Name;
    }
    public static class Program
    {
        private static void Main(string[] args)
        {
            var references = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(ICode).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => (ICode)Activator.CreateInstance(x)).OrderBy(x => x.Name);

            var input = args.FirstOrDefault();

            if (string.IsNullOrEmpty(input))
            {
                foreach (var reference in references) Console.WriteLine($"{reference.Name}");
                input = Console.ReadLine();
            }

            input = input.ToLower();

            var code = references.First(x => x.Name.ToLower().Contains(input));

            if (args != null && args.Length > 1 && args[1] == "b")
            {
                var retval = new[] { code.GetType().GetMethod("Execute") };

                foreach (var item in retval)
                {
                    Console.WriteLine(item);
                }
                BenchmarkRunner.Run(code.GetType(), retval);
            }
            else
            {
                code.Execute();
            }

            Console.ReadLine();
        }
    }
}