using System;
using System.Linq;

namespace CSharpReference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var references = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(IReference).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => (IReference) Activator.CreateInstance(x)).ToList();

            int.TryParse(args.FirstOrDefault(), out var code);

            foreach (var reference in references) Console.WriteLine($"{reference.Code} - {reference.Name}");

            if (code == 0) code = int.Parse(Console.ReadLine());

            references.First(x => x.Code == code).Execute();
        }
    }
}