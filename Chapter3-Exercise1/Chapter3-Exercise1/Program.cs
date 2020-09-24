using System;
using System.Collections.Generic;
using System.Linq;

namespace Chapter3_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            Exercise1(numbers);
            Exercise2(numbers);
            Exercise3(numbers);
            Exercise4(numbers);
        }

        static void Exercise1(List<int> numbers)
        {
            Console.WriteLine("- Chapter3 Exercise3.1.1 (Can be divided 8 or 9) -");
            Console.WriteLine("Can divide 8 or 9? = {0}", numbers.Exists(n => n % 8 == 0 || n % 9 == 0));
            Console.WriteLine();
        }

        static void Exercise2(List<int> numbers)
        {
            Console.WriteLine("- Chapter3 Exercise3.1.2 (Divided 2.0) -");
            foreach (var item in numbers)
                Console.WriteLine("{0,-3} /2.0= {1,5:#.#}", item, item / 2.0f);
            Console.WriteLine();
        }

        static void Exercise3(List<int> numbers)
        {
            Console.WriteLine("- Chapter3 Exercise3.1.3 (Over 50) -");
            var query = numbers.Where(n => n >= 50);
            foreach (var n in query)
                Console.WriteLine(n);
            Console.WriteLine();
        }

        static void Exercise4(List<int> numbers)
        {
            Console.WriteLine("- Chapter3 Exercise3.1.4 (Double) -");
            var doubledNumbers = numbers.Select(n => n * 2).ToList<int>();
            foreach (var n in doubledNumbers)
                Console.WriteLine("{0,-3} *2= {1,4}", numbers[doubledNumbers.IndexOf(n)], n);
            Console.WriteLine();
        }
    }
}