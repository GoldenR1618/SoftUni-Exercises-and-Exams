namespace _04.Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CubicAssault
    {
        public static void Main(string[] args)
        {
            //  30/100

            Dictionary<string, Dictionary<string, int>> dictionary = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "Count em all")
            {
                string[] inputArr = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string regionName = inputArr[0];
                string type = inputArr[1];
                int count = int.Parse(inputArr[2]);
                
                if (!dictionary.ContainsKey(regionName))
                {
                    dictionary[regionName] = new Dictionary<string, int>
                    {
                        ["Black"] = 0,
                        ["Green"] = 0,
                        ["Red"] = 0
                    };
                }

                if (type == "Green")
                {
                    while (count >= 1000000)
                    {
                        dictionary[regionName]["Red"]++;

                        count -=1000000;
                    }

                    if (dictionary[regionName]["Red"] >= 1000000)
                    {
                        while (dictionary[regionName]["Red"] >= 1000000)
                        {
                            dictionary[regionName]["Black"]++;

                            dictionary[regionName]["Red"] -=1000000;
                        }
                    }

                    dictionary[regionName]["Green"] += count;
                }
                else if (type == "Red")
                {
                    while (count >= 1000000)
                    {
                        dictionary[regionName]["Black"]++;

                        count -= 1000000;
                    }

                    dictionary[regionName]["Red"] += count;
                }
                else
                {
                    dictionary[regionName]["Black"] += count;
                }

                input = Console.ReadLine();
            }

            foreach (var item in dictionary.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var i in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"-> {i.Key} : {i.Value}");
                }
            }
        }
    }
}
