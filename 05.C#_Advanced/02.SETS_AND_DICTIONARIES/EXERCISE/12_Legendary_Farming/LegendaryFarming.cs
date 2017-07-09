namespace _12_Legendary_Farming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LegendaryFarming
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dictMaterial = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            };

            Dictionary<string, int> dictJunk = new Dictionary<string, int>();

            while (true)
            {
                if (dictMaterial["shards"] >= 250 || dictMaterial["fragments"] >= 250 || dictMaterial["motes"] >= 250)
                {
                    break;
                }

                string[] input = Console.ReadLine().Split(' ');

                for (int i = 0, j = 1; j < input.Length; i += 2, j += 2)
                {
                    if (dictMaterial["shards"] >= 250 || dictMaterial["fragments"] >= 250 || dictMaterial["motes"] >= 250)
                    {
                        break;
                    }

                    int quantity = int.Parse(input[i]);
                    string material = input[j].ToLower();

                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        dictMaterial[material] += quantity;
                    }
                    else
                    {
                        if (!dictJunk.ContainsKey(material))
                        {
                            dictJunk[material] = 0;
                        }

                        dictJunk[material] += quantity;
                    }
                }
            }

            string win = "";

            foreach (var item in dictMaterial)
            {
                if (item.Value >= 250)
                {
                    win = item.Key;
                    dictMaterial[item.Key] = item.Value - 250;

                    break;
                }
            }

            switch (win)
            {
                case "shards": win = "Shadowmourne"; break;
                case "fragments": win = "Valanyr"; break;
                case "motes": win = "Dragonwrath"; break;
                default:
                    break;
            }

            Console.WriteLine($"{win} obtained!");

            foreach (var item in dictMaterial.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in dictJunk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
