using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> resourceQuantity = new Dictionary<string, decimal>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                decimal quantity = decimal.Parse(Console.ReadLine());

                if (resourceQuantity.ContainsKey(resource))
                {
                    resourceQuantity[resource] += quantity;
                }
                else
                {
                    resourceQuantity.Add(resource, quantity);
                }  
            }

            foreach (var item in resourceQuantity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
