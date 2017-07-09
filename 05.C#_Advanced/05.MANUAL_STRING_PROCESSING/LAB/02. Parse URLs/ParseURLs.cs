namespace _02.Parse_URLs
{
    using System;

    public class ParseURLs
    {
        public static void Main(string[] args)
        {
            string[] url = Console.ReadLine().Split(new string[] { "://" }, StringSplitOptions.RemoveEmptyEntries);

            if (url.Length > 2 || url.Length == 1)
            {
                Console.WriteLine("Invalid URL");
            }
            else
            {
                string protocol = url[0];

                int serverEndIndex = url[1].IndexOf("/");

                if (serverEndIndex == -1)
                {
                    Console.WriteLine("Invalid URL");
                }
                else
                {
                    string server = url[1].Substring(0, serverEndIndex);
                    string resource = url[1].Substring(serverEndIndex + 1);

                    Console.WriteLine($"Protocol = {protocol}");
                    Console.WriteLine($"Server = {server}");
                    Console.WriteLine($"Resources = {resource}");
                }
            }
        }
    }
}
