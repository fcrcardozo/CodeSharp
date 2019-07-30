using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpReference
{
    class Program
    {
        static void Main(string[] args)
        {
            var references = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(IReference).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => (IReference) Activator.CreateInstance(x)).ToList();

            foreach (var reference in references)
            {
                Console.WriteLine($"{reference.Code} - {reference.Name}");
            }

            var code = int.Parse(Console.ReadLine());

            references.First(x => x.Code == code).Execute();
        }
    }
}
