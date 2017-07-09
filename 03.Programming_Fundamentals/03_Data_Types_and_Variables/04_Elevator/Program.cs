using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberPeople = int.Parse(Console.ReadLine());
            double capacityElevator = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(numberPeople / capacityElevator);

            Console.WriteLine(courses);
        }
    }
}
