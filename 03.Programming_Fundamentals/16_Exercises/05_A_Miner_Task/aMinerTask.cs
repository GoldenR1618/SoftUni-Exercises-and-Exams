namespace _05_A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class aMinerTask
    {
        public static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");

            Dictionary<string, decimal> resourceQuantity = new Dictionary<string, decimal>();

            for (int i = 0; i < input.Length; i = i + 2)
            {
                if (input[i] == "stop")
                {
                    break;
                }

                string resource = input[i];
                decimal quantity = decimal.Parse(input[i+1]);

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
                File.AppendAllText("output.txt", $"{item.Key.ToString()} -> {item.Value.ToString()}{Environment.NewLine}");
            }
        }
    }
}
