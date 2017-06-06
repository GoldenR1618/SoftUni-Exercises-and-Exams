﻿namespace C_Sharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;
    using System.Diagnostics;
    using System.Globalization; //За да може да се пoлзва "CultureInfo".

    public class CSharp
    {
        public static void Main(string[] args)
        {
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*
                        Ctrl + K, Ctrl + D – подравнява скоби и табове.

                        Променливи:

                        Целочислени типове                                                  sbyte (-128/127), byte (0/255), short (-32'768/32'767), ushort (0/65'535), int (-2'147'483'648/2'147'483'647), uint (0/4'294'967'295), long (-9'223'372'036'854'775'808/9'223'372'036'854'775'807), ulong (0/18'446'744'073'709'551'615), BigInteger - add reverences -> Assemblies -> System.Numerics -> using System.numerics;

                        Реални типове с плаваща запетая                                     float (7 diggits), double (15-16 digits)

                        Реални типове с десетична точност                                   decimal (28-29 significant digits)

                        Булев тип                                                           bool (true/false)
                        (True, False), a =’a’; b =’b’; bool r = a < b – Може да сравнява подредбата на буквите в азбуката освен големината на цифри.
                        Може да инициализираме променливата – bool c = true;

                        Символен тип                                                        char (a, b, 1, %,…)

                        Символен низ (стринг)                                               string(Hello, Word,…)

                        Обектен тип                                                         object



                        int days = (int)(years * 365.2422);                                 Насилствено преобразуване на резултата в даден тип данни (Кастване).



                        Екранирани последователности:
                        \'  –  единична кавичка.
                        \"  –  двойна кавичка.
                        \\  –  лява наклонена черта.
                        \n  –  нов ред.
                        \t  –  отместване (табулация).
                        \uXXXX  –  символ, зададен с Unicode номера си, например \ u03A7.



                        Spase -> \s
                        White spase -> \t \r \s \n \c



                        Debugger:
                        Start without Debugger: [Ctrl+F5]
                        Start with the Debugger: [F5]
                        Toggle a breakpoint: [F9]
                        Trace the program: [F10] - стъпка по стъпка / [F11] - стъпка по стъпка, но влиза и в извиканите методи.
                        Using the Locals / Watches
                        Conditional breakpoints
                        Enter debug mode after exception



                        /// - именуване на class.



                        //IEnumerable - всичко от този тип, можем само да foreach-ме и нищо друго. LINQ връща IEnumerable тип данни. За това след употреба завършваме с ToArray, ToList... освен ако не искаме само да го foreach за финал. 
                        //ICollection - позволява освен да foreach-ме и: Add, Clear, Contains, CopyTo, Remove.



                        //TryParse() - ако стойноста е от приемлив тип, се записва в out-a.
                        //int number = 0;
                        //bool parsed = int.TryParse(Console.ReadLine(), out number);

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            ConsoleKeyInfo key = Console.ReadKey();                         //Четене чрез ReadKey. ConsoleKeyInfo съдържа символа, но и специални клавиши ако са натиснати.
            Console.WriteLine();
            Console.WriteLine("Character entered: " + key.KeyChar);
            Console.WriteLine("Special keys: " + key.Modifiers);
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            Console.WriteLine("Моля въведете произволен текст.");
            var letter = Console.Read();                                    //Чете САМО първият символ и присвоява САМО неговият номер.
            Console.WriteLine(letter);
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            Convert.ToInt32("abc", 16);                                     //Конвертира стринг в шеснайсетичен интеджер.
            Console.WriteLine((char)('а' + 14));                            //Дай ми 15-та буква от азбуката.
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ////////////////// Value and Reference Types: /////////////////////////////////////////
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            /*
            Value Types: 
                        public static void Main(string[] args)
                        {
                        int num = 5;
                        Increment(num, 15);
                        Console.WriteLine(num);         //5
                        }

                        private static void Increment(int num, int value)
                        {
                        num += value;                   //20
                        }

            Reference Types:
                        public static void Main(string[] args)
                        {
                        int[] nums = { 5 };
                            Increment(nums, 15);
                        Console.WriteLine(nums[0]);     //20
                        }

                        private static void Increment(int[] nums, int value)
                        {
                        nums[0] += value;               //20
                        }
            */
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ////////////////// Демонстрация на Math.: /////////////////////////////////////////
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Round(1.556, 2)     - Закръглява до вторият знак след дес. запетая. = {0}", Math.Round(1.556, 2));
            Console.WriteLine(" Math.Round(1.554, 2)     - Закръглява до вторият знак след дес. запетая. = {0}", Math.Round(1.554, 2));
            Console.WriteLine(" Math.Round(9.98, 0)      - Закръглява до най-близкото цяло число.        = {0}", Math.Round(9.98, 0));
            Console.WriteLine(" Math.Round(9.12, 0)      - Закръглява до най-близкото цяло число.        = {0}", Math.Round(9.12, 0));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Abs(3 - 5)          - Вади разликата без знак.                      = {0}", Math.Abs(3 - 5));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Max(3, 5)           - Връща най-голямото число.                     = {0}", Math.Max(3, 5));
            Console.WriteLine(" Math.Min(3, 5)           - Връща най-малкото число.                      = {0}", Math.Min(3, 5));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Truncate(9.98)      - Закръглява надолу до цяло число.              = {0}", Math.Truncate(9.98));
            Console.WriteLine(" Math.Truncate(9.12)      - Закръглява надолу до цяло число.              = {0}", Math.Truncate(9.12));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Floor(9.98)         - Закръглява надолу до цяло число.              = {0}", Math.Floor(9.98));
            Console.WriteLine(" Math.Floor(9.12)         - Закръглява надолу до цяло число.              = {0}", Math.Floor(9.12));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.Ceiling(9.98)       - Закръглява нагоре до цяло число.              = {0}", Math.Ceiling(9.98));
            Console.WriteLine(" Math.Ceiling(9.12)       - Закръглява нагоре до цяло число.              = {0}", Math.Ceiling(9.12));
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine(" Math.PI                  - Извежда числото Пи.                           = {0}", Math.PI);
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ////////////////// Работа с дати: /////////////////////////////////////////
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            DateTime today = DateTime.Now;                                  //Задаване на днешна дата в променлива от тип дата.
            DateTime answer = today.AddDays(36);                            //Добавяне на 36 дни към днешната дата.
            DateTime answer2 = today.AddDays(-36);                          //Изваждане на 36 дни от днешната дата.
            Console.WriteLine("Today: {0:dddd}", today);                    //Отпечатване на днешният ден във формат ден от седмицата.
            Console.WriteLine("36 days from today: {0:dddd}", answer);      //Отпечатване на резултатният ден във същият формат.
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

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ////////////////// Целочислено делене: /////////////////////////////////////////
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            int a = 10;
            var b = 10;
            Console.WriteLine(a / 4);           //Резултата не е дробно число 2.5, а е 2, защото е int.
            Console.WriteLine(b / 4.0);         //Резултат e дробно делене.
            Console.WriteLine(10 % 4);          //Целочислено делене. 2*4=8, 10-8=2 остатък ->2.
            Console.WriteLine(59.7 % 1);        //Връща дробната част.
            Console.WriteLine(59 % 2);          //Проверка за честност като се проверява резултата (остатъка) дали е 0 (четно), различно от нула (нечетно).                                  
            Console.WriteLine(59 % 10);         //Резултата е 9. Напрактика % делението връща ЕДЕНИЦАТА.
            Console.WriteLine(59 / 10);         //Резултата е 5. Напрактика int делението връща ДЕСЕТИЦАТА.
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ////////////////// Таймер: /////////////////////////////////////////
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            string result = "";
            Stopwatch st = new Stopwatch();

            st.Start();

            for (int i = 0; i < 50000; i++)
            {
                result += (Convert.ToString(i, 2) + "\n");
            }

            st.Stop();

            Console.WriteLine(st.Elapsed);
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            ////////////////// Генериране на рандом чилса: /////////////////////////////////////////
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            var random = new Random();              //var random = new Random(100); - Можемн да зададем ръчно инишъл числото. Ако го оставим празно, ще чете милисекунди от времето.
            var randomNumber = random.Next(2, 6);   //Ще генерира произволно число от 2 до 6-1 -> 5.
            Console.WriteLine(randomNumber);
            /*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        }
    }
}
