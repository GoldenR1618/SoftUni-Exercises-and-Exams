using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studenti = int.Parse(Console.ReadLine());

            double topStudentBroi = 0.00;
            double between4499Broi = 0.00;
            double between3399Broi = 0.00;
            double failBroi = 0.00;
            double average = 0.00;

            for (int i = 1; i <= studenti; i++)
            {
                double ocenka = double.Parse(Console.ReadLine());

                if (ocenka >= 2.00 && ocenka <= 2.99)
                {
                    failBroi++;

                }
                else if (ocenka >= 3.00 && ocenka <= 3.99)
                {
                    between3399Broi++;

                }
                else if (ocenka >= 4.00 && ocenka <= 4.99)
                {
                    between4499Broi++;

                }
                else if (ocenka >= 5.00)
                {
                    topStudentBroi++;

                }
                average += ocenka;
            }

            Console.WriteLine("Top students: {0:F2}%", (topStudentBroi / studenti) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", (between4499Broi / studenti) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", (between3399Broi / studenti) * 100);
            Console.WriteLine("Fail: {0:F2}%", (failBroi / studenti) * 100);
            Console.WriteLine("Average: {0:F2}", average / studenti);
        }
    }
}
