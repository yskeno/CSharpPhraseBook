using System;
using System.Collections;
using System.Collections.Generic;

namespace SalesCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var sales = new SalesCounter("sales.csv");
            var amountPerStore = sales.GetPerStoreSales();

            PrintAmountSales(amountPerStore);
            //foreach (var obj in amountPerStore)
            //{
            //    Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            //}

            // Exercise 2.3
            var amountPerCategory = sales.GetPerCategorySales();
            PrintAmountSales(amountPerCategory);
        }

        static void PrintAmountSales(IDictionary<string, int> amount)
        {
            foreach (var obj in amount)
            {
                Console.WriteLine("{0,-8} \\{1:n0}", obj.Key, obj.Value);
            }
            Console.WriteLine();
        }
    }
}