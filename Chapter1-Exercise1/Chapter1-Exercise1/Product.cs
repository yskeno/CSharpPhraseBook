using System;

namespace Sale
{
    class Product
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(int code,string name,int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }

        public int GetTax()
        {
            return (int)(Price * 0.10f);
        }

        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
}