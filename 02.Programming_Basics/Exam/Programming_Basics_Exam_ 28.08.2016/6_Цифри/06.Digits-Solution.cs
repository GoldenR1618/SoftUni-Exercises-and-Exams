using System;

class Digits
{
	static void Main(string[] args)
	{
		var num = int.Parse(Console.ReadLine());

		var numCopy = num;
		var digit3 = numCopy % 10;
		numCopy /= 10;
		var digit2 = numCopy % 10;
		numCopy /= 10;
		var digit1 = numCopy % 10;

		for (int i = 0; i < digit1 + digit2; i++)
		{
			for (int j = 0; j < digit1 + digit3; j++)
			{
				if (num % 5 == 0)
				{
					num -= digit1;
					Console.Write("{0} ", num);
				}
				else if (num % 3 == 0)
				{
					num -= digit2;
					Console.Write("{0} ", num);
				}
				else
				{
					num += digit3;
					Console.Write("{0} ", num);
				}
			}
			Console.WriteLine();
		}
	}
}