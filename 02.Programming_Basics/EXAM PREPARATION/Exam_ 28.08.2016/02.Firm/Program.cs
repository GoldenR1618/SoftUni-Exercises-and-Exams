using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2___Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            int neobhodimiChasove = int.Parse(Console.ReadLine());
            int dniRazpolaga = int.Parse(Console.ReadLine());
            int broiSluzhiteliIzvanredno = int.Parse(Console.ReadLine());
            
            double result = Math.Floor(dniRazpolaga * 0.90 * 8 + broiSluzhiteliIzvanredno * 2* dniRazpolaga);
            double plus = result - neobhodimiChasove;
            double minus = neobhodimiChasove - result;

            if (neobhodimiChasove <= result)
            {
                Console.WriteLine("Yes!{0} hours left.", plus);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", minus);
            }
        }
    }
}
