namespace Streams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;                //Задължително, когато работим с файлове.

    public class Streams
    {
        public static void Main(string[] args)
        {
            //**********************************************************************************************************************
            //Файлове:

            if (!File.Exists("myfile.txt"))     //Проверка дали файла съществува.
            {
                File.Create("myfile.txt");      //Създаване на файл.
            }

            string file = File.ReadAllText("myfile.txt");               //reads everything at once and returns a string
            string[] file1 = File.ReadAllLines("myfile.txt");           //reads line by line and returns a collection. Прочита целият файл на куп.
            IEnumerable<string> file3 = File.ReadLines("myfile.txt");   //Чете линия по линия, а не целият файл на куп.

            Console.WriteLine(file);

            foreach (var line in file1)
            {
                Console.WriteLine(line);
            }



            //WriteAllText() – takes a string and writes it to a file - пише върху старото съдържание.
            File.WriteAllText("myfile.txt", "Files are fun");

            //WriteAllLines() – takes a collection and writes every element on a new line - пише върху старото съдържание.
            string[] names = { "pesho", "ivan", "stamat", "mariika" };
            File.WriteAllLines("myfile.txt", names);

            Console.WriteLine();

            //There are also AppendAllText() and AppendAllLines() methods, that just add additional text to a file.
            //При Append не се трие старото съдържание, а се добавя новото отдолу. 

            //FileInfo
            var file2 = "myfile.txt";

            var fileinfo = new FileInfo(file2);

            Console.WriteLine(fileinfo.FullName);       //C:\Users\ilian\OneDrive\Projects\01.Learning_C_Sharp\Работа_с_файлове\bin\Debug\myfile.txt
            Console.WriteLine(fileinfo.Name);           //myfile.txt
            Console.WriteLine(fileinfo.Length);         //30        - Ако го разделим на 1024.0 ще го получим в Mb.
            Console.WriteLine(fileinfo.Attributes);     //Archive
            Console.WriteLine(fileinfo.Directory);      //C:\Users\ilian\OneDrive\Projects\01.Learning_C_Sharp\Работа_с_файлове\bin\Debug
            Console.WriteLine(fileinfo.DirectoryName);  //C:\Users\ilian\OneDrive\Projects\01.Learning_C_Sharp\Работа_с_файлове\bin\Debug - това обаче е стринг!
            Console.WriteLine(fileinfo.Exists);         //True
            Console.WriteLine(fileinfo.Extension);      //.txt

            //Местене на файл.
            File.Move(file2, $"../{file2}");             //Премести файла едно ниво нагоре във файловата система и го кръсти отново file2

            //Преименуване на файл.
            File.Move(file2, "anothername.txt");

            //Изстриване на файл.
            File.Delete("text.txt");

            //**********************************************************************************************************************
            //Директории:
            //CreateDirectory() – creates the directory and all subdirectories at the specified path, unless they already exist
            Directory.CreateDirectory("Test");

            //Delete() – deletes an empty directory
            Directory.Delete("Test");

            //Delete() – deletes a non empty directory
            Directory.Delete("Test", true);

            //Move() – moves a file or directory to a new location 
            Directory.Move("Test", "New Folder");

            //GetFiles() – returns the names of files (including their paths) in the specified directory 
            string[] filesInDir = Directory.GetFiles("TestFolder");

            //GetDirectories() – returns the names of subdirectories (including their paths) in the specified directory
            string[] subDirs = Directory.GetDirectories("TestFolder");

            //Начин да обиколим всички под-директории и файлове в един рут.
            string currentDir = Directory.GetCurrentDirectory();    //Връща пътя на директорията в която се изпълнява програмата.

            DirectoryInfo dirInfo = new DirectoryInfo(currentDir);

            DirectoryInfo rootDir = dirInfo.Parent.Parent;          //Качвам се две стъпки нагоре в директориите.

            TravereseDir(rootDir);                                  //Метод
        }

        public static void TravereseDir(DirectoryInfo currentDir, string prefix = "")
        {
            foreach (var dir in currentDir.GetDirectories())        //Обикалям всички директории в рута. 
            {
                Console.WriteLine(prefix + dir.Name);
                TravereseDir(dir, prefix + "--");
            }

            foreach (var file in currentDir.GetFiles())             //Обикалям всички файлове в съответната директория.
            {
                Console.WriteLine(prefix + "--" + file.Name);
            }
        }
    }
}
