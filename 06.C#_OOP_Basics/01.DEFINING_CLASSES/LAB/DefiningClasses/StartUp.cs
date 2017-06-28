using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main()
    {
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        string input = Console.ReadLine();

        while (input != "End")
        {
            string[] inputArgs = input.Split(' ');

            string command = inputArgs[0];
            int id = int.Parse(inputArgs[1]);
            double amount;

            switch (command)
            {
                case "Create":
                    Create(id, accounts);
                    break;

                case "Deposit":
                    amount = double.Parse(inputArgs[2]);
                    Deposit(id, amount, accounts);
                    break;

                case "Withdraw":
                    amount = double.Parse(inputArgs[2]);
                    Withdraw(id, amount, accounts);
                    break;

                case "Print":
                    Print(id, accounts);
                    break;


                default:
                    break;
            }

            input = Console.ReadLine();
        }
    }

    public static void Print(int id, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        var currentAccount = accounts.First(a => a.Key == id);

        Console.WriteLine(currentAccount.Value.ToString());
    }

    public static void Withdraw(int id, double amount, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        var currentAccount = accounts.First(a => a.Key == id);

        if ((currentAccount.Value.Balance - amount) < 0)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            currentAccount.Value.Withdraw(amount);
        }
    }

    public static void Deposit(int id, double amount, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        var currentAccount = accounts.First(a => a.Key == id);

        currentAccount.Value.Deposit(amount);
    }

    public static void Create(int id, Dictionary<int, BankAccount> accounts)
    {
        if (!accounts.ContainsKey(id))
        {
            BankAccount current = new BankAccount()
            {
                ID = id
            };

            accounts.Add(id, current);
        }
        else
        {
            Console.WriteLine("Account already exists");
        }
    }
}
