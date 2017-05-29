namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BashSoftProgram
    {
        public static void Main(string[] args)
        {

        }

        public static void TraverseDirectory(string path)
        {
            OutputWriter.WriteEmptyLine;
            int initialIdentation = path.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(path);

            while (subFolders.Count != 0)
            {
                subFolders.Dequeue();
                OutputWriter.WriteMessageOnNewLine(path);
                subFolders.Enqueue(path);
            }
        }
    }
}
