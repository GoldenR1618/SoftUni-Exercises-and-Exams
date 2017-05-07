namespace _07_Fix_Emails
{
    using System;
    using System.Collections.Generic;

    public class FixEmails
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Dictionary<string, string> emails = new Dictionary<string, string>();

            while (name != "stop")
            {
                string email = Console.ReadLine();

                string checkEnd = email.Substring(email.Length - 2, 2).ToLower();

                if (checkEnd != "uk" && checkEnd != "us")
                {
                    emails.Add(name, email);
                }

                name = Console.ReadLine();
            }

            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
