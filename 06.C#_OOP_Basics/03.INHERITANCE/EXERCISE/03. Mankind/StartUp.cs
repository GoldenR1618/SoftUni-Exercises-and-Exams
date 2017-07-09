using System;

public class StartUp
{
    public static void Main()
    {
        try
        {
            string[] input1 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] input2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Student student = new Student(input1[0], input1[1], input1[2]);
            Worker worker = new Worker(input2[0], input2[1], decimal.Parse(input2[2]), decimal.Parse(input2[3]));

            Console.WriteLine(student.ToString());
            Console.WriteLine();
            Console.WriteLine(worker.ToString());
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}