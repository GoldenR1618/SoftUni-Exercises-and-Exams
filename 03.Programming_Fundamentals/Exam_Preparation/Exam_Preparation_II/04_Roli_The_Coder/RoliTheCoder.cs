namespace _04_Roli_The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoliTheCoder
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Event> listOfevents = new List<Event>();

            while (input != "Time for Code")
            {
                List<string> line = input.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string id = line[0];
                string eventName = line[1];

                if (eventName[0] != '#')
                {
                    input = Console.ReadLine();
                    continue;
                }

                eventName = eventName.Substring(1);

                Event current = new Event();

                if (listOfevents.Any(x => x.ID == id))
                {
                    Event exist = listOfevents.First(x => x.ID == id);

                    if (exist.EventName != eventName)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    for (int i = 2; i < line.Count; i++)
                    {
                        exist.Participant.Add(line[i]);
                    }

                    input = Console.ReadLine();
                    continue;
                }

                current.ID = id;
                current.EventName = eventName;
                current.Participant = new HashSet<string>();
                for (int i = 2; i < line.Count; i++)
                {
                    current.Participant.Add(line[i]);
                }

                listOfevents.Add(current);

                input = Console.ReadLine();
            }

            foreach (var item in listOfevents.OrderByDescending(x => x.Participant.Count).ThenBy(x => x.EventName))
            {
                Console.WriteLine($"{item.EventName} - {item.Participant.Count}");
                foreach (var index in item.Participant.OrderBy(x => x))
                {
                    Console.WriteLine(index);
                }
            }
        }
    }

    public class Event
    {
        public string ID { get; set; }
        public string EventName { get; set; }
        public HashSet<string> Participant { get; set; }
    }
}
