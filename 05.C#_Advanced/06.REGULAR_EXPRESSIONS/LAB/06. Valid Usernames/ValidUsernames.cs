namespace _06.Valid_Usernames
{
    using System;
    using System.Text.RegularExpressions;

    public class ValidUsernames
    {
        public static void Main(string[] args)
        {
            string user = Console.ReadLine();

            Regex regex = new Regex(@"^[A-Za-z0-9\-_]{3,16}$");

            while (user != "END")
            {
                Match match = regex.Match(user);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                user = Console.ReadLine();
            }
        }
    }
}
