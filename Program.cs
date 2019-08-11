using System;
using System.Linq;

namespace CSharpReference
{
    public interface ICode
    {
        int Code { get; }
        void Execute();
    }
    public static class Program
    {
        private static void Main(string[] args)
        {
            var references = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(ICode).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => (ICode) Activator.CreateInstance(x)).ToList().OrderBy(x => x.Code);

            int.TryParse(args.FirstOrDefault(), out var code);

            foreach (var reference in references) Console.WriteLine($"{reference.Code} - {reference.GetType().Name}");

            if (code == 0) code = int.Parse(Console.ReadLine());

            references.First(x => x.Code == code).Execute();
        }
    }
}