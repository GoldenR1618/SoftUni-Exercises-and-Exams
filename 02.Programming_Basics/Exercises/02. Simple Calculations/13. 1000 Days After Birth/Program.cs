using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace _13._1000_Days_After_Birth
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var thousandDaysAfteerBirth = birthdate.AddDays(999);
            Console.WriteLine(thousandDaysAfteerBirth.ToString("dd-MM-yyyy"));
        }
    }
}
