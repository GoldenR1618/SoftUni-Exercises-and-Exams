namespace RolliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RolliTheCoder_02
    {
        static void Main()
        {
            var events = new List<Event>();

            var input = Console.ReadLine();

            while (!input.Equals("Time for Code"))
            {
                var inputSplit = input.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var id = int.Parse(inputSplit[0]);
                var name = inputSplit[1].Substring(1);

                if (inputSplit[1][0].Equals('#') && !events.Any(e => e.ID == id) && !events.Any(e => e.Name == name))
                {
                    var someEvent = new Event(id, name);
                    var participants = inputSplit.Skip(2).Take(inputSplit.Length - 2).Distinct();

                    foreach (var participant in participants.Distinct())
                    {
                        someEvent.ParticipantList.Add(participant.Trim());
                    }
                    events.Add(someEvent);
                }
                else if (inputSplit[1][0].Equals('#'))
                {
                    var eventName = events.Where(e => e.ID == id).ElementAt(0);
                    if (eventName.Name == name)
                    {
                        var participants = inputSplit.Skip(2).Take(inputSplit.Length - 2).Distinct();

                        foreach (var participant in participants.Distinct())
                        {
                            if (!eventName.ParticipantList.Contains(participant))
                            {
                                eventName.ParticipantList.Add(participant.Trim());
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var e in events.OrderByDescending(e => e.ParticipantList.Count).ThenBy(e => e.Name))
            {
                Console.WriteLine("{0} - {1}", e.Name, e.ParticipantList.Count);
                foreach (var participant in e.ParticipantList.OrderBy(a => a))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }

    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<string> ParticipantList { get; set; }

        public Event(int id, string name)
        {
            ID = id;
            Name = name;
            ParticipantList = new List<string>();
        }
    }
}