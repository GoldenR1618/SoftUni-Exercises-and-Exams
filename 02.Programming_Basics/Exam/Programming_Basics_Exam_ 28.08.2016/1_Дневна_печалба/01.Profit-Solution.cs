using System;

namespace test
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var days = int.Parse(Console.ReadLine());
			var money = double.Parse(Console.ReadLine());
			var dollarRate = double.Parse(Console.ReadLine());

			var monthSalary = days * money;
			var moneyPerYear = monthSalary * 12 + monthSalary * 2.5;
			var moneyAfterTaxes = moneyPerYear - 25 * moneyPerYear / 100;

			var averageMoney = moneyAfterTaxes * dollarRate / 365 ;

			Console.WriteLine("{0:F2}", averageMoney);
		}
	}
}
