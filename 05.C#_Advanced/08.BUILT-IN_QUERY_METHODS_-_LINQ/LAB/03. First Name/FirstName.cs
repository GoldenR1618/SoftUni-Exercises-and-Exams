namespace _03.First_Name
{
    using System;
    using System.Linq;

    public class FirstName
    {
        public static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            string[] letters = Console.ReadLine().Split(' ').OrderBy(x => x).ToArray();

            foreach (var letter in letters)
            {
                string result = names.Where(w => w.ToLower().StartsWith(letter.ToLower())).FirstOrDefault();

                if (result != null)
                {
                    Console.WriteLine(result);
                    return;                     //Преостановява изпълнението на програмта.
                }
            }

            Console.WriteLine("No match");
        }
    }
}
