namespace _02_SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUni_Karaoke
    {
        public static void Main(string[] args)
        {
            List<string> listOfname = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> listOfsong = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            int check = 0;
            List<Awards> awards = new List<Awards>();

            while (input != "dawn")
            {
                string[] stagePerformance = input.Split(',');

                string name = stagePerformance[0].Trim();
                string song = stagePerformance[1].Trim();
                string award = stagePerformance[2].Trim();

                Awards current = new Awards();

                if (listOfname.Contains(name) && listOfsong.Contains(song))
                {
                    if (awards.Any(x => x.Name == name))
                    {
                        Awards exist = awards.First(x => x.Name == name);

                        if (!exist.Award.Contains(award))
                        {
                            exist.Award.Add(award);
                        }
                    }
                    else
                    {
                        current.Name = name;
                        current.Award = new List<string>();
                        current.Award.Add(award);
                    }

                    if (current.Name != null && current.Award != null)
                    {
                        awards.Add(current);
                        check++;
                    }
                }

                input = Console.ReadLine();
            }

            if (check == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var index in awards.OrderByDescending(x => x.Award.Count).ThenBy(x => x.Name))
                {
                    Console.WriteLine($"{index.Name}: {index.Award.Count} awards");
                    index.Award.Sort();

                    foreach (var item in index.Award)
                    {
                        Console.WriteLine($"--{item}");
                    }
                }
            }
        }
    }

    public class Awards
    {
        public string Name { get; set; }
        public List<string> Award { get; set; }
    }
}
