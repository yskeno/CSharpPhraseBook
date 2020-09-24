using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter3_Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };

            Exercise1(names);
            Exercise2(names);
            Exercise3(names);
            Exercise4(names);
        }

        static void Exercise1(List<string> names)
        {
            Console.WriteLine("- Chapter3 Exercise3.2.1 (Index of input line) -");
            Console.Write("Enter a city name: ");
            var line = Console.ReadLine();
            Console.WriteLine("{0} is {1} order of names.", line, names.IndexOf(line));
            Console.WriteLine();
        }

        static void Exercise2(List<string> names)
        {
            Console.WriteLine("- Chapter3 Exercise3.2.2 (Count including 'o') -");
            Console.WriteLine("Number of city including 'o': {0}", names.Count(s => s.Contains("o")));
            Console.WriteLine();
        }

        static void Exercise3(List<string> names)
        {
            Console.WriteLine("- Chapter3 Exercise3.2.3 (Names including 'o') -");
            var includeO = names.Where(s => s.Contains("o")).ToArray();
            foreach (var s in includeO)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        static void Exercise4(List<string> names)
        {
            Console.WriteLine("- Chapter3 Exercise3.2.4 (Number of characters of city name started 'B') -");
            Console.WriteLine("Number of characters of city name started 'B': {0}", string.Join("", names.Where(s => s.StartsWith("B")).ToArray()).Length);
            Console.WriteLine();
        }
    }
}