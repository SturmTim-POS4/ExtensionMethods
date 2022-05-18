using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = new List<int> { 3, 6, 89, 5, 4, 77, 2 };
            var doubles = new List<double> { 4.4, 6.2, 77.4, 2.1, 11.2 };
            var strings = new List<string> { "a", "b", "ccc", "d", "eee", "f" };

            var persons = new List<Person>
            {
                new Person{Firstname = "Hansi", Lastname = "Huber", Age = 66},
                new Person{Firstname = "Heinzi", Lastname = "Prüller", Age = 77},
                new Person{Firstname = "Susi", Lastname = "Maurer", Age = 55}
            };

            Console.WriteLine("Fabian, Elias, Tamara".FirstAndLast());
            
            Console.WriteLine(DateTime.Now.Yesterday());
            
            Console.WriteLine(10.Fact());

            Console.WriteLine(string.Join(",",strings.UseOnly(x => x.Length < 3)));
            
            Console.WriteLine(string.Join("; ",doubles.UseOnly(x => x < 20.0)));
            
            Console.WriteLine(string.Join(",",ints.UseOnly(x => x < 20)));
            
            var fullnames = persons.Transform(x => $"{x.Firstname} {x.Lastname} [{x.Age}]");
            Console.WriteLine(string.Join(",",fullnames));
        }
    }
}