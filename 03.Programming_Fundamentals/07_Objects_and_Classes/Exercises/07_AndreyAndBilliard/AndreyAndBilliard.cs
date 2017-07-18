using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBilliard02
{
    class AndreyAndBilliard02
    {
        static void Main()
        {
            Dictionary<string, double> menu = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] input = Console.ReadLine().Split('-');

                if (!menu.ContainsKey(input[0]))
                {
                    menu.Add(input[0], double.Parse(input[1]));
                }
                else
                {
                    menu[input[0]] = double.Parse(input[1]);
                }

            }

            List<Client> clients = new List<Client>();

            while (true)
            {
                string inputTwo = Console.ReadLine();

                if (inputTwo == "end of clients")
                {
                    break;
                }

                string[] inputTwoCom = inputTwo.Split('-', ',');

                string name = inputTwoCom[0];
                string boughtProduct = inputTwoCom[1];
                double quantity = double.Parse(inputTwoCom[2]);

                if (!menu.ContainsKey(boughtProduct)) { continue; }

                Client currentClient = new Client();

                currentClient.ShopList = new Dictionary<string, double>();
                currentClient.Name = inputTwoCom[0];
                currentClient.ShopList.Add(boughtProduct, quantity);

                if (clients.Any(x => x.Name == name))
                {
                    Client existingCustomer = clients.First(x => x.Name == name);

                    if (existingCustomer.ShopList.ContainsKey(boughtProduct))
                    {
                        existingCustomer.ShopList[boughtProduct] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[boughtProduct] = quantity;
                    }
                }
                else
                {
                    clients.Add(currentClient);
                }
            }

            /// Това го правим само за да направим bill-a:
            foreach (var customer in clients)
            {
                foreach (var item in customer.ShopList)
                {

                    foreach (var product in menu)
                    {
                        if (item.Key == product.Key) { customer.Bill += item.Value * product.Value; }
                    }
                }
            }

            var ordered = clients
                            .OrderBy(x => x.Name)
                            .ThenBy(x => x.Bill)
                            .ToList();

            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);

                foreach (KeyValuePair<string, double> item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine("Bill: {0:f2}", customer.Bill);

            }

            Console.WriteLine("Total bill: {0:F2}", clients.Sum(c => c.Bill));
        }
    }

    class Client
    {
        public string Name { get; set; }
        public Dictionary<string, double> ShopList { get; set; }
        public double Bill { get; set; }

    }
}