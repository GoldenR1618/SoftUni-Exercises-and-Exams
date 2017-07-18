namespace _07_Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Sales_Report
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> sales = new List<Sale>();

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                var currentSale = new Sale
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])
                };

                sales.Add(currentSale);
            }

            SortedDictionary<string, decimal> result = new SortedDictionary<string, decimal>();

            foreach (var item in sales)
            {
                if (!result.ContainsKey(item.Town))
                {
                    result[item.Town] = 0;
                }

                result[item.Town] += item.Price * item.Quantity;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key:F2} -> {item.Value:F2}");
            }
            
        }
    }

    public class Sale
    {
        public string Town { get; set; }

        public string Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }
    }
}
