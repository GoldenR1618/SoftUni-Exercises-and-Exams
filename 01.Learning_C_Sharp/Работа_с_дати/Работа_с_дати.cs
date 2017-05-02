using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;                                                         //За да може да се пoлзва "CultureInfo".

namespace Работа_с_дати
{
    class Работа_с_дати
    {
        static void Main(string[] args)
        {
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            DateTime today = DateTime.Now;                                  //Задаване на днешна дата в променлива от тип дата.
            DateTime answer = today.AddDays(36);                            //Добавяне на 36 дни към днешната дата.
            DateTime answer2 = today.AddDays(-36);                          //Изваждане на 36 дни от днешната дата.
            Console.WriteLine("Today: {0:dddd}", today);                    //Отпечатване на днешният ден във формат ден от седмицата.
            Console.WriteLine("36 days from today: {0:dddd}", answer);		//Отпечатване на резултатният ден във същият формат.
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            //using System.Globalization; - Зарежда CultureInfo.
            // CultureInfo.InvariantCulture - Искам неутрален формат за датата.
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Въведете дата във формат dd-MM-yyyy");
            var birthdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var thousandDaysAfteerBirth = birthdate.AddDays(999);
            Console.WriteLine(thousandDaysAfteerBirth.ToString("dd-MM-yyyy"));
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            DateTime d = new DateTime(2009, 10, 23, 15, 30, 22);
            Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);                //(23/10/ 2009 15:30:22)
            Console.WriteLine("{0:d.MM.yy г .}", d);                        //(23/10/ 09 г .)
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            //Write a program that reads two dates in format dd-MM-yyyy and prints the number of working days between these two dates inclusive.
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>()
            {
                DateTime.ParseExact("01-01-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("03-03-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016", "dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            int workingDays = 0;

            for (DateTime currentDay = startDate; currentDay <= endDate; currentDay = currentDay.AddDays(1))
            {
                DateTime checkDate = new DateTime(2016, currentDay.Month, currentDay.Day);

                if (currentDay.DayOfWeek != DayOfWeek.Saturday
                    && currentDay.DayOfWeek != DayOfWeek.Sunday
                    && !holidays.Contains(checkDate))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            TimeSpan time = TimeSpan.FromSeconds(4563);                 //Конвертиране на double в секунди и от там в time формат.
            //FromDays(long), FromHours(double), FromMilliseconds(double), FromMinutes(double), FromTicks(double)
            int timeSec = int.Parse(Console.ReadLine()) % 86400;        //Махаме цял ден, ако ни подадът огромно число.
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        }
    }
}
