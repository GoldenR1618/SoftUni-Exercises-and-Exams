namespace _06_A_Miner_s_Task
{
    using System;
    using System.Collections.Generic;

    public class AMinersTask
    {
        public static void Main(string[] args)
        {
            string input = "";

            Dictionary<string, double> minerDict = new Dictionary<string, double>();

            while ((input = Console.ReadLine()) != "stop")
            {
                if (!minerDict.ContainsKey(input))
                {
                    minerDict.Add(input, double.Parse(Console.ReadLine()));                    
                }
                else
                {
                    minerDict[input] += double.Parse(Console.ReadLine());
                }
            }

            foreach (var item in minerDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }        
        }
    }
}
