using System;
using System.Collections.Generic;
using System.Linq;
using _05.KingGambitExtended.Entities;

namespace _05.KingGambitExtended
{
    public class StartUp
    {
        private static King king;
        private static readonly List<Soldier> soldiers;

        static StartUp()
        {
            soldiers = new List<Soldier>();
        }

        public static void Main()
        {
            // Read input
            ReadKingData();
            ReadRoyalGuards();
            ReadFootmans();

            // Process
            Run();
        }

        private static void Run()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] args = line.Split();

                switch (args[0])
                {
                    case "Attack":
                        king.Attack();
                        break;

                    case "Kill":
                        Soldier tryToKill = soldiers.First(n => n.Name == args[1]);
                        tryToKill.Health--;

                        if (tryToKill.Health == 0)
                        {
                            king.KingAttacked -= tryToKill.ProtectKing;
                            soldiers.Remove(tryToKill);
                        }
                        break;
                }
            }
        }

        private static void ReadFootmans()
        {
            string[] footmans = Console.ReadLine().Split();

            foreach (var footmanName in footmans)
            {
                Footman footman = new Footman(footmanName);
                king.KingAttacked += footman.ProtectKing;
                soldiers.Add(footman);
            }
        }

        private static void ReadRoyalGuards()
        {
            string[] guards = Console.ReadLine().Split();

            foreach (var guardName in guards)
            {
                RoyalGuard rg = new RoyalGuard(guardName);
                king.KingAttacked += rg.ProtectKing;
                soldiers.Add(rg);
            }
        }

        private static void ReadKingData()
        {
            king = new King(Console.ReadLine());
        }
    }
}