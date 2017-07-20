using System;
using System.Text;

public class StartUp
{
    public static void Main(string[] args)
    {
        string ferrariName = typeof(Ferrari).Name;
        string iCarInterfaceName = typeof(ICar).Name;

        bool isCreated = typeof(ICar).IsInterface;
        if (!isCreated)
        {
            throw new Exception("No interface ICar was created");
        }

        string driver = Console.ReadLine();

        ICar car = new Ferrari(driver);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{car.Model}/{car.Brakes()}/{car.Gas()}/{car.Driver}");
        Console.WriteLine(sb.ToString());
    }
}
