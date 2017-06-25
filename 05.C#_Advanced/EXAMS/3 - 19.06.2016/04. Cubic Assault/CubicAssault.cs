namespace _04.Cubic_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CubicAssault
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dictionary = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "Count em all")
            {
                string[] inputArr = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string regionName = inputArr[0];
                string type = inputArr[1];
                long count = long.Parse(inputArr[2]);
                
                if (!dictionary.ContainsKey(regionName))
                {
                    dictionary[regionName] = new Dictionary<string, long>
                    {
                        ["Black"] = 0,
                        ["Green"] = 0,
                        ["Red"] = 0
                    };
                }

                if (type == "Green")
                {
                    dictionary[regionName]["Green"] += count;

                    while (dictionary[regionName]["Green"] >= 1000000)
                    {
                        dictionary[regionName]["Red"]++;

                        dictionary[regionName]["Green"] -= 1000000;
                    }

                    if (dictionary[regionName]["Red"] >= 1000000)
                    {
                        while (dictionary[regionName]["Red"] >= 1000000)
                        {
                            dictionary[regionName]["Black"]++;

                            dictionary[regionName]["Red"] -=1000000;
                        }
                    }
                }
                else if (type == "Red")
                {
                    dictionary[regionName]["Red"] += count;

                    while (dictionary[regionName]["Red"] >= 1000000)
                    {
                        dictionary[regionName]["Black"]++;

                        dictionary[regionName]["Red"] -= 1000000;
                    }
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
