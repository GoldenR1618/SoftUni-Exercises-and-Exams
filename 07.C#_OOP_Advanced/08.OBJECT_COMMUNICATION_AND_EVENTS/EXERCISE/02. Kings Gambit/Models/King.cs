using System;

public class King
{
    public event EventHandler UnderAttack;

    public King(string name)
    {
        this.Name = name;
    }

    public string Name { get; private set; }

    public void OnUnderAttack()
    {
        Console.WriteLine($"King {this.Name} is under attack!");

        if (UnderAttack != null)
        {
            UnderAttack(this, new EventArgs());
        }
    }
}