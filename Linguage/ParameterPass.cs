using System;
using System.Linq;

namespace CSharpReference.Linguage
{
    public class Person
    {
        public string Name { get; set; }

        public Person getPersonWithOtherName(string name)
        {
            Name = name;
            return this;
        }
    }
    public class ParameterPass : ICode
    {
        public void Foo1(Person person)
        {
            // This change won't be seen by the caller: it's changing the value
            // of the parameter.
            person = new Person() { Name = "1" };
        }

        public void Foo2(Person person)
        {
            // This change *will* be seen by the caller: it's changing the data
            // within the object that the parameter value refers to.
            person.getPersonWithOtherName("2");
        }

        public void Foo3(ref Person person)
        {
            // This change *will* be seen by the caller: it's changing the value
            // of the parameter, but we're using pass by reference
            person = new Person() { Name = "3" };
        }
        public int Code => 5;
        public void Execute()
        {
            var person = new Person() { Name = "0" };

            Foo1(person);
            Console.WriteLine(person.Name); // 0
            Foo2(person);
            Console.WriteLine(person.Name); // 2
            Foo3(ref person);
            Console.WriteLine(person.Name); // 3
        }
    }
}