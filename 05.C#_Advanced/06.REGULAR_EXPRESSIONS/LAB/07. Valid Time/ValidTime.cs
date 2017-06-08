namespace _07.Valid_Time
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidTime
    {
        public static void Main(string[] args)
        {
            //  80/100

            string time = Console.ReadLine();

            Regex regex = new Regex(@"^(0[0-9]|1[01]):[0-5][0-9]:[0-5][0-9] [AP]M$");

            while (time != "END")
            {
                Match match = regex.Match(time);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                time = Console.ReadLine();
            }
        }
    }
}
