using System;
using System.Collections.Generic;
using System.Linq;  // for using LINQ

namespace Chapter3_Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };

            Query1(names);
            Query2(names);
            Query3(names);
        }

        public static void Query1(List<string> vs)
        {
            var names = new List<string>(vs);

            Console.WriteLine("--- Chapter3.4.1 ---");
            IEnumerable<string> query = names.Where(s => s.Length <= 5).Select(s => s.ToLower());
            //var query = names.Where(s => s.Length <= 5).Select(s => s.ToLower());
            foreach (string s in query)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        public static void Query2(List<string> vs)
        {
            var names = new List<string>(vs);

            Console.WriteLine("--- Chapter3.4.4 - 3.8 ---");
            var query = names.Where(s => s.Length <= 5);
            foreach (var item in query)
                Console.WriteLine(item);
            Console.WriteLine("------");

            names[0] = "Osaka";
            foreach (var item in query)
                Console.WriteLine(item);
            Console.WriteLine();
        }

        public static void Query3(List<string> vs)
        {
            var names = new List<string>(vs);

            Console.WriteLine("--- Chapter3.4.4 - 3.9 ---");
            var query = names.Where(s => s.Length <= 5).ToArray();
            foreach (var item in query)
                Console.WriteLine(item);
            Console.WriteLine("------");

            names[0] = "Osaka";
            foreach (var item in query)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}

namespace CSharpPhrase.Extensions
{
    public static class StringExtensions
    {
        public static string Reverse(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return string.Empty;
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }
    }
}