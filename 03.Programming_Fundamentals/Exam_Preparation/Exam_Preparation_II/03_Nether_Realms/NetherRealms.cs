namespace _03_Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class NetherRealms
    {
        public static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(new char[] { ',',' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            char[] nonTotalHealthChar = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*', '/', '.' };

            List<Dragon> listOfDragons = new List<Dragon>();

            foreach (var name in names)
            {
                int health = 0;                                     //Сума от ASCI кодовете на всички символи без забранените.
                double damage = 0;                                  //Сумата от всички числа. Всички * и / накрая ги ползвам да умножавам или деля резултата по 2.
                Regex digit = new Regex(@"[\+\-]*[0-9.]+[0-9]*");
                MatchCollection digitMatches = digit.Matches(name);

                foreach (var match in digitMatches)
                {
                    damage += double.Parse(match.ToString().TrimStart('.'));
                }

                for (int i = 0; i < name.Length; i++)
                {
                    char symbol =name[i];

                    if (!nonTotalHealthChar.Contains(symbol))
                    {
                        health += symbol;
                    }

                    if (symbol == '*')
                    {
                        damage *= 2;
                    }

                    if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }

                Dragon current = new Dragon()
                {
                    Name = name,
                    Health = health,
                    Damage = damage
                };

                listOfDragons.Add(current);
            }

            foreach (var dragon in listOfDragons.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{dragon.Name} - {dragon.Health} health, {dragon.Damage:F2} damage");
            }
        }
    }

    public class Dragon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }
    }
}
