using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        ICollection<ISoldier> list = new List<ISoldier>();

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] args = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            switch (args[0])
            {
                case "Private":
                    ISoldier _private = new Private(args[1], args[2], args[3], double.Parse(args[4]));
                    list.Add(_private);
                    break;

                case "LeutenantGeneral":
                    HashSet<Private> privates = new HashSet<Private>();
                    for (int i = 5; i < args.Length; i++)
                    {
                        string currentId = args[i];
                        Private currentPrivate = (Private)list.First(x => x.Id == currentId);
                        privates.Add(currentPrivate);
                    }
                    ISoldier leutenantGeneral = new LeutenantGeneral(args[1], args[2], args[3], double.Parse(args[4]), privates);
                    list.Add(leutenantGeneral);
                    break;

                case "Engineer":
                    HashSet<Repair> repairs = new HashSet<Repair>();
                    for (int i = 6, j = 7; j < args.Length; i+=2, j+=2)
                    {
                        Repair currRepair = new Repair(args[i], int.Parse(args[j]));
                        repairs.Add(currRepair);
                    }
                    ISoldier engineer = new Engineer(args[1], args[2], args[3], double.Parse(args[4]), args[5], repairs);
                    list.Add(engineer);
                    break;

                case "Commando":
                    HashSet<Mission> missions = new HashSet<Mission>();
                    for (int i = 6, j = 7; j < args.Length; i+=2, j+=2)
                    {
                        try
                        {
                            Mission currMission = new Mission(args[i], args[j]);
                            missions.Add(currMission);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    try
                    {
                        ISoldier commando = new Commando(args[1], args[2], args[3], double.Parse(args[4]), args[5], missions);
                        list.Add(commando);
                    }
                    catch (Exception)
                    {
                        break;
                    }
                    break;

                case "Spy":
                    ISoldier spy = new Spy(args[1], args[2], args[3], int.Parse(args[4]));
                    list.Add(spy);
                    break;

                default:
                    break;
            }

            input = Console.ReadLine();
        }

        foreach (var item in list)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
