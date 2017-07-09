namespace TechFundamentalsExam
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public sealed class Legion
    {
        public Legion(string name, long activity)
        {
            this.Name = name;
            this.Activity = activity;
            this.Soldiers = new Dictionary<string, long>();
        }

        public string Name { get; private set; }

        public long Activity { get; set; }

        public Dictionary<string, long> Soldiers { get; set; }

        public override string ToString()
        {
            return $"{this.Activity} : {this.Name}";
        }
    }

    class Startup
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var legions = new Dictionary<string, Legion>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { '=', ' ', ':', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                long lastActivity = long.Parse(input[0]);
                string legionName = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);

                if (legions.ContainsKey(legionName))
                {
                    if (legions[legionName].Soldiers.ContainsKey(soldierType))
                    {
                        legions[legionName].Soldiers[soldierType] += soldierCount;
                    }
                    else
                    {
                        legions[legionName].Soldiers.Add(soldierType, soldierCount);
                    }

                    if (legions[legionName].Activity < lastActivity)
                    {
                        legions[legionName].Activity = lastActivity;
                    }
                }
                else
                {
                    legions.Add(legionName, new Legion(legionName, lastActivity));
                    legions[legionName].Soldiers.Add(soldierType, soldierCount);
                }
            }

            string[] outputFormat = Console.ReadLine().Split(new[] { '\\' }, StringSplitOptions.None);

            if (outputFormat.Length > 1)
            {
                long activity = long.Parse(outputFormat[0]);
                string soldierType = outputFormat[1];
                var found = new Dictionary<string, long>();

                foreach (var legion in legions)
                {
                    if (legion.Value.Activity >= activity)
                    {
                        continue;
                    }

                    foreach (var soldier in legion.Value.Soldiers)
                    {
                        if (soldier.Key == soldierType)
                        {
                            found.Add(legion.Key, soldier.Value);
                        }
                    }
                }

                foreach (var item in found.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
            else
            {
                var foundWithType = legions.Where(x => x.Value.Soldiers.Keys.Contains(outputFormat[0]));

                foreach (var soldier in foundWithType.OrderByDescending(x => x.Value.Activity))
                {
                    Console.WriteLine(soldier.Value);
                }
            }
        }
    }
}