namespace _04.Merging_two_files_into_third_one
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    public class MergingTwoFilesIntoThirdOne
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
