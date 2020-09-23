using System.Collections.Generic;
using System.IO;

namespace SalesCalculator
{
    class SalesCounter
    {
        private IEnumerable<Sale> _sales;

        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }

        private static IEnumerable<Sale> ReadSales(string filePath)
        {
            var sales = new List<Sale>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var items = line.Split(',');
                var sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

        public IDictionary<string, int> GetPerStoreSales()
        {
            var dictStore = new Dictionary<string, int>();

            foreach (var sale in _sales)
            {
                if (dictStore.ContainsKey(sale.ShopName))
                    dictStore[sale.ShopName] += sale.Amount;
                else
                    dictStore[sale.ShopName] = sale.Amount;
            }
            return dictStore;
        }

        // Exercise 2.3
        public IDictionary<string, int> GetPerCategorySales()
        {
            var dictCategory = new Dictionary<string, int>();

            foreach (var sale in _sales)
            {
                if (dictCategory.ContainsKey(sale.ProductCategory))
                    dictCategory[sale.ProductCategory] += sale.Amount;
                else
                    dictCategory[sale.ProductCategory] = sale.Amount;
            }
            return dictCategory;
        }

    }
}