using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {   //Алгоритъм на Евклид за намиране на НОД: 
            //Взимайки двете дадени на входа на алгоритъма числа a и b, провери дали b е равно на 0.
            //Ако да, числото a е търсеният най-голям общ делител.
            //Ако не, повтори процеса, като използваш за входни данни b и остатъка, получен при деленето a на b (винаги се дели голямото на малкото число).

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int a = Math.Max(x, y);
            int b = Math.Min(x, y);

            //Console.WriteLine(mod);
            while (b != 0)
            {
                int c = a % b;
                a = b;
                b = c;
            }
            Console.WriteLine("НОД е: " + a);
        }
    }
}
