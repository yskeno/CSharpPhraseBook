using System;
using System.Linq;

namespace Chapter4_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var yearMonths = new YearMonth[]
            {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };

            Console.WriteLine("--Ex4-2-2------");
            Exercise2_2(yearMonths);
            Console.WriteLine();

            Console.WriteLine("--Ex4-2-4------");
            Exercise2_4(yearMonths);
            Console.WriteLine();

            Console.WriteLine("--Ex4-2-5------");
            Exercise2_5(yearMonths);
            Console.WriteLine();
        }

        private static void Exercise2_2(YearMonth[] yearMonths)
        {
            foreach (var item in yearMonths)
                Console.WriteLine(item);
        }

        static YearMonth FindFirst21C(YearMonth[] yearMonths)
        {
            foreach (var item in yearMonths)
            {
                if (item.Is21Century)
                    return item;
            }
            return null;
        }

        private static void Exercise2_4(YearMonth[] yearMonths)
        {
            Console.WriteLine(FindFirst21C(yearMonths)?.ToString() ?? "21世紀のデータはありません");
        }

        private static void Exercise2_5(YearMonth[] yearMonths)
        {
            var newYMs = yearMonths.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var item in newYMs)
                Console.WriteLine($"[{item}]");
        }
    }
}
