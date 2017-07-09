namespace Exception_Handling
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            //The System.Exception Class
            //Message – text description of the exception
            //StackTrace – the snapshot of the stack at the moment of exception throwing

            try
            {
                string text = "123";    //abc/123
                int num = 3 + int.Parse(text);

                //File.ReadAllLines("dasdas.txt");

                Console.WriteLine(num);

                var arr = new int[10];
                Console.WriteLine(arr[100]);  //100/9
            }
            catch (IndexOutOfRangeException ex)     //Ексебшън за конкретен проблем. (ЗАДЪЛЖИТЕЛНО КОНКРЕТНИТЕ СЕ СЛАГАТ НАД ОСНОВНИЯТ).
            {
                Console.WriteLine("Index out of range");
                Console.WriteLine(ex.Message);
                File.AppendAllText("debug.log", ex.StackTrace + Environment.NewLine + new string('-', 100) + Environment.NewLine);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("File not found");
                Console.WriteLine(ex.Message);
                File.AppendAllText("debug.log", ex.StackTrace + Environment.NewLine + new string('-', 100) + Environment.NewLine);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Wrong format");
                Console.WriteLine(ex.Message);
                File.AppendAllText("debug.log", ex.StackTrace + Environment.NewLine + new string('-', 100) + Environment.NewLine);
            }
            catch (Exception ex)                    //Това е основен ексебшън. Той обхваща всички варианти.
            {
                Console.WriteLine("Sorry, something was wrong!");
                Console.WriteLine(ex.Message);      //Input string was not in a correct format.
                File.AppendAllText("debug.log", ex.StackTrace + Environment.NewLine + new string('-', 100) + Environment.NewLine); //StackTrace - дава подробно описание на случката. Записвам го във файл.
            }
            finally
            {
                Console.WriteLine("Final");         // This block will always execute
            }

            //Създаване на собствени ексепшъни.
            var number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new Exception("Моля въведете цифра по-голяма от 0!");
            }
        }
    }
}
