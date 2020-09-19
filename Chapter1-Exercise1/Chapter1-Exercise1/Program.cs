using System;

namespace Chapter1_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dorayaki = new Sale.Product(98, "Dora-Yaki", 210);

            Console.WriteLine("{0} \\{1}", dorayaki.Name, dorayaki.GetPriceIncludingTax());
        }
    }
}