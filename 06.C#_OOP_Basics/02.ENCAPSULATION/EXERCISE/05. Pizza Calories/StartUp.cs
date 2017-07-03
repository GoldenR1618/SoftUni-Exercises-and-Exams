using System;

public class StartUp
{
    public static void Main()
    {
        try
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string command = args[0];

                switch (command)
                {
                    case "Dough":
                        DoughPrint(input);
                        break;

                    case "Topping":
                        ToppingPrint(input);
                        break;

                    case "Pizza":
                        PizzaPrint(input);
                        break;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void PizzaPrint(string input)
    {
        string[] pizzaArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string pizzaName = pizzaArgs[1];
        int toppingsCount = int.Parse(pizzaArgs[2]);

        if (toppingsCount < 0 || toppingsCount > 10)
        {
            throw new ArgumentException($"Number of toppings should be in range [0..10].");
        }

        string[]  doughArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string flourType = doughArgs[1];
        string technique = doughArgs[2];
        int doughWeight = int.Parse(doughArgs[3]);

        Dough dough = new Dough(flourType, technique, doughWeight);

        Pizza pizza = new Pizza(pizzaName, dough);

        for (int i = 0; i < toppingsCount; i++)
        {
            string[] toppingArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string toppingType = toppingArgs[1];
            int toppingWeight = int.Parse(toppingArgs[2]);

            Topping topping = new Topping(toppingType, toppingWeight);

            pizza.AddTopping(topping);
        }

        Console.WriteLine(pizza.ToString());
    }

    private static void ToppingPrint(string input)
    {
        string[] toppingArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Topping toping = new Topping(toppingArgs[1], int.Parse(toppingArgs[2]));
        Console.WriteLine($"{toping.CalculateCalories():F2}");
    }

    private static void DoughPrint(string input)
    {
        string[] args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Dough dough = new Dough(args[1], args[2], int.Parse(args[3]));
        Console.WriteLine($"{dough.CalculateCalories():F2}");
    }
}