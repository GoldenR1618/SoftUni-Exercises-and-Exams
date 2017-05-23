namespace Learning_C_Sharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;
    using System.Globalization;

    public class LearningCSharp
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
            ConsoleKeyInfo key = Console.ReadKey();                         //Четене чрез ReadKey. ConsoleKeyInfo съдържа символа, но и специални клавиши ако са натиснати.
            Console.WriteLine();
            Console.WriteLine("Character entered: " + key.KeyChar);
            Console.WriteLine("Special keys: " + key.Modifiers);
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Console.WriteLine("Моля въведете произволен текст.");
            //var letter = Console.Read();                                  //Чете САМО първият символ и присвоява САМО неговият номер.
            //Console.WriteLine(letter);
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
            Convert.ToInt32("abc", 16);                                     //Конвертира стринг в шеснайсетичен интеджер.
            Console.WriteLine((char)('а' + 14));                            //Дай ми 15-та буква от азбуката.
/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        }
    }
}
