namespace Problem4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;
    using System.Text.RegularExpressions;

    public class Problem4
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, Dictionary<long, long>>> dictionary = new Dictionary<string, Dictionary<string, Dictionary<long, long>>>();

            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split(new string[] { " = ", " -> ", ":" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                long lastActivity = long.Parse(inputArr[0]);
                string legionName = inputArr[1];
                string soldierType = inputArr[2];
                long soldierCount = long.Parse(inputArr[3]);

                if (dictionary.ContainsKey(lastActivity))
                {
                    dictionary[lastActivity] = new Dictionary<string, Dictionary<string, long>>();
                }
                else
                {

                }

                



                if (dictionary.ContainsKey(legionName))      //If a given legion already exists
                {
                    if (dictionary[legionName].ContainsKey(soldierType))
                    {
                        dictionary[legionName][soldierType][lastActivity] += soldierCount;
                    }
                    else
                    {
                        dictionary[legionName][soldierType].Add(lastActivity, soldierCount);
                    }      
                }

                if (true)
                {

                }



                if (!dictionary[lastActivity][legionName].ContainsKey(soldierType))
                {
                    dictionary[lastActivity][legionName][soldierType] = 0;
                }

                dictionary[lastActivity][legionName][soldierType] += soldierCount;
            }

            Console.WriteLine();

            foreach (var item1 in dictionary)
            {
                foreach (var item2 in item1.Value)
                {
                    foreach (var item3 in item2.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        Console.WriteLine("{0} -> {1} -> {2} -> {3}", item1.Key, string.Join(", ", item2.Key), string.Join(", ", item3.Key), string.Join(", ", item3.Value));
                    }
                }
            }
        }
    }
}
