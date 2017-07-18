namespace _04_Merge_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class MergeFiles
    {
        public static void Main(string[] args)
        {
            List<string> fileOne = File.ReadAllText("FileOne.txt").Split(new char[] { '\n', ',', ';', ':', '.', '!',
                    '(', ')', '"', '-', '\\', '/', '[', ']', ' ',
                    '?', '\r', '`', '_', '{', '}', '<', '>', '\'' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> fileTwo = File.ReadAllText("FileTwo.txt").Split(new char[] { '\n', ',', ';', ':', '.', '!',
                    '(', ')', '"', '-', '\\', '/', '[', ']', ' ',
                    '?', '\r', '`', '_', '{', '}', '<', '>', '\'' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();

            int count = Math.Min(fileOne.Count, fileTwo.Count);

            for (int i = 0; i < count; i++)
            {
                File.AppendAllText("Output.txt", fileOne[i] + Environment.NewLine);
                File.AppendAllText("Output.txt", fileTwo[i] + Environment.NewLine);
            }
        }
    }
}
