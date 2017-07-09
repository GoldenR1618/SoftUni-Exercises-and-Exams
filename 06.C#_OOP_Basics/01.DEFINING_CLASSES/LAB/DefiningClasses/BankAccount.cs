using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAccount
{
    private int id;
    private double balance;

    /*public BankAccount()
    {

    }

    public BankAccount(int id)
    {
        this.ID = id;
    }*/

    public int ID
    {
        get
        {
            return this.id;
        }
        set
        {
            this.id = value;
        }
    }

    public double Balance
    {
        get
        {
            return this.balance;
        }
        set
        {
            this.balance = value;
        }
    }

    public void Deposit(double amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(double amount)
    {
        this.Balance -= amount;
    }

    public override string ToString()
    {
        return $"Account ID{this.ID}, balance {this.Balance:F2}";
    }
}
