using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    public void Start()
    {
        string[] phoneNumbers = Console.ReadLine().Split(new[] { ' ' });
        string[] webUrls = Console.ReadLine().Split(new[] { ' ' });

        Smartphone phone = new Smartphone(phoneNumbers, webUrls);
        Console.Write(phone.ToString());
    }
}
