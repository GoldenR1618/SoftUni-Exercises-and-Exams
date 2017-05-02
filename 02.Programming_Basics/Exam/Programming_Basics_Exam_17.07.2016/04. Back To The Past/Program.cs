using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double наследениПари = double.Parse(Console.ReadLine());
            int година = int.Parse(Console.ReadLine());

            double похарчениПари = 0.00;
            
            int възраст = 18;

            for (int i = 1800; i <= година; i++)
            {
                if (i % 2 != 0)
                {
                    похарчениПари = похарчениПари + 12000 + (50 * възраст);
                    възраст++;
                }
                else
                {
                    похарчениПари = похарчениПари + 12000;
                    възраст++;
                }
            }

            double остатък = наследениПари - похарчениПари;
            double недостик = похарчениПари - наследениПари;

            if (наследениПари >= похарчениПари)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", остатък);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", недостик);
            }
        }
    }
}
