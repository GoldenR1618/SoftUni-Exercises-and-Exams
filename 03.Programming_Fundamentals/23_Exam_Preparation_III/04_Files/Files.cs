namespace _04_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Files
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, Dictionary<string, long>>> rootExtFileSize = new Dictionary<string, Dictionary<string, Dictionary<string, long>>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Regex d = new Regex(@"(?<=\\).*(?=\.\w+;\d+)");     //Вземи всичко между "\" и ".дума;цифри". Взима всички папки от ляво без първата. 
                Regex e = new Regex(@"(?<=\.)\w+(?=;)");            //Вземи "дума" между "." и ";"
                Regex s = new Regex(@"(?<=;)\d+");                  //Вземи "цифри" след ";"
                Match df = d.Match(input);
                Match mExt = e.Match(input);
                Match mSize = s.Match(input);

                string[] dirsFile = df.ToString().Split('\\');
                string[] dirroot = input.Split('\\');

                string root = dirroot[0];
                string ext = mExt.ToString();
                string file = dirsFile[dirsFile.Length - 1];
                long size = long.Parse(mSize.ToString());

                if (!rootExtFileSize.ContainsKey(root))
                {
                    rootExtFileSize[root] = new Dictionary<string, Dictionary<string, long>>();
                }

                if (!rootExtFileSize[root].ContainsKey(ext))
                {
                    rootExtFileSize[root][ext] = new Dictionary<string, long>();
                }

                if (!rootExtFileSize[root][ext].ContainsKey(file))
                {
                    rootExtFileSize[root][ext][file] = 0;
                }

                rootExtFileSize[root][ext][file] = size;
            }

            string[] comm = Console.ReadLine().Split();

            string commExt = comm[0];
            string commRoot = comm[2];

            bool isPrint = false;

            foreach (var item in rootExtFileSize)
            {
                if (commRoot == item.Key)
                {
                    foreach (var index in item.Value)
                    {
                        if (commExt == index.Key)
                        {
                            foreach (var i in index.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                            {
                                isPrint = true;
                                Console.WriteLine($"{i.Key}.{index.Key} - {i.Value} KB");
                            }
                        }
                    }
                }
            }

            if (isPrint == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
