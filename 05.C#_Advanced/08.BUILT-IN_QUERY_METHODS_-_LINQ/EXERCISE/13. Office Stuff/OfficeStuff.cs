namespace _13.Office_Stuff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OfficeStuff
    {
        public static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> companyProductAmount = new SortedDictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " - ", "|" }, StringSplitOptions.RemoveEmptyEntries);
                string company = input[0];
                string product = input[2];
                int amount = int.Parse(input[1]);

                if (!companyProductAmount.ContainsKey(company))
                {
                    companyProductAmount[company] = new Dictionary<string, int>();
                }

                if (!companyProductAmount[company].ContainsKey(product))
                {
                    companyProductAmount[company][product] = 0;
                }

                companyProductAmount[company][product] += amount;
            }

            foreach (var company in companyProductAmount)
            {
                Console.WriteLine($"{company.Key}: {string.Join(", ", company.Value.Select(s => s.Key + "-" + s.Value))}");
            }
        }
    }
}
