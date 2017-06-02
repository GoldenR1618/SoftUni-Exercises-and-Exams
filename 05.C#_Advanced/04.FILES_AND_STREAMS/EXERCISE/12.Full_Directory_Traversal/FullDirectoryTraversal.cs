namespace _12.Full_Directory_Traversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FullDirectoryTraversal
    {
        public static void Main(string[] args)
        {
            // get and store file info about all files in the current directory
            string[] filePaths = Directory.GetFiles(@"../../", "*.*", SearchOption.AllDirectories);

            List<FileInfo> files = filePaths.Select(path => new FileInfo(path)).ToList();

            // sort file info
            var sorted =
                files.OrderBy(file => file.Length).GroupBy(file => file.Extension).OrderByDescending(group => group.Count()).ThenBy(group => group.Key);

            // locate desktop
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // create report file
            StreamWriter writer = new StreamWriter(desktop + "/report.txt");
            foreach (var group in sorted)
            {
                writer.WriteLine(group.Key);

                foreach (var y in group)
                {
                    writer.WriteLine("--{0} - {1:F3}kb", y.Name, y.Length / 1024.0);
                }
            }
            writer.Close();

            // open report file
            System.Diagnostics.Process.Start(desktop + "/report.txt");
        }
    }
}
