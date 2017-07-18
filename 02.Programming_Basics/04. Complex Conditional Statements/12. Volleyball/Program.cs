using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var tipGodina = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var vladiIgralDni = ((48-h) * 3/4) + h + (p*2/3);

            switch (tipGodina)
            {
                case "normal": Console.WriteLine(Math.Truncate(vladiIgralDni)); break;
                case "leap": Console.WriteLine(Math.Truncate(vladiIgralDni + (vladiIgralDni*0.15))); break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
