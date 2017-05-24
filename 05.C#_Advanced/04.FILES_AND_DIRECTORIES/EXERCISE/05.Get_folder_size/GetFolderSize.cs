namespace _05.Get_folder_size
{
    using System;
    using System.IO;

    public class GetFolderSize
    {
        public static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");
            double sum = 0;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("оutput.txt", sum.ToString());
        }
    }
}
