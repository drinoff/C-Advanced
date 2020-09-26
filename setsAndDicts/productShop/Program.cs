using System;
using System.Collections.Generic;
using System.Linq;


namespace productShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopProduct = new SortedDictionary<string, List<string>>();
            var productPrice = new Dictionary<string, double>();
            while (true)
            {
                var input = InputParser();
                if (input.Contains("Revision"))
                {
                    break;
                }
                var shopName = input[0];
                var product = input[1];
                var price = double.Parse(input[2]);
                if (!shopProduct.ContainsKey(shopName))
                {
                    shopProduct.Add(shopName, new List<string>());

                }

                if (!shopProduct[shopName].Contains(product))
                {
                    shopProduct[shopName].Add(product);
                }




                productPrice[product] = price;

            }
            foreach (var shop in shopProduct)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var element in shop.Value)
                {
                    Console.WriteLine($"Product: {element}, Price: {productPrice[element]}");
                }

            }

        }
        public static string[] InputParser()
        {
            return Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
        }

    }
}
