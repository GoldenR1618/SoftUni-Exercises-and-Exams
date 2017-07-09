using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> keyMaterial = new Dictionary<string, long>();

            keyMaterial["shards"] = 0;
            keyMaterial["fragments"] = 0;
            keyMaterial["motes"] = 0;

            Dictionary<string, long> notKeyMaterial = new Dictionary<string, long>();

            bool getMaterial = true;
            string win = "";

            while (getMaterial)
            {
                List<string> list = Console.ReadLine().Split(' ').ToList();
                for (int i = 0; i < list.Count; i = i + 2)
                {
                    long quloty = long.Parse(list[i]);
                    string material = list[i + 1].ToLower();

                    if (keyMaterial.ContainsKey(material))
                    {
                        keyMaterial[material] += quloty;
                        if (keyMaterial[material] >= 250)
                        {
                            win = material;
                            keyMaterial[material] -= 250;
                            getMaterial = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!notKeyMaterial.ContainsKey(material))
                        {
                            notKeyMaterial[material] = 0;
                        }

                        notKeyMaterial[material] += quloty;

                    }
                }
            }


            string first = WindMethod(win);
            Console.WriteLine(WindMethod(win) + " obtained!");

            keyMaterial = keyMaterial
                .OrderBy(x => x.Key)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            notKeyMaterial = notKeyMaterial
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var pait in keyMaterial)
            {
                Console.WriteLine("{0}: {1}", pait.Key, pait.Value);
            }
            foreach (var pair in notKeyMaterial)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }


        }

        private static string WindMethod(string win)
        {
            switch (win)
            {
                case "motes": return "Dragonwrath"; break;
                case "fragments": return "Valanyr"; break;
                case "shards": return "Shadowmourne"; break;
                default: return "goran"; break;

            }
        }
    }
}
