using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum = sum + n % 10;             //Връща последната цифра на n.
                n = n / 10;                     //Изтрива последната цифра на n.
            } while (n > 0);
            Console.WriteLine(sum);
        }
    }
}
