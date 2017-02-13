namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var menuDictionary = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-');
                var productName = input[0];
                var productPrice = decimal.Parse(input[1]);

                menuDictionary[productName] = productPrice;
            }

            var orderLine = Console.ReadLine().Split('-', ',');

            var customers = new List<Customer>();
            while (orderLine[0] != "end of clients")
            {
                var customerName = orderLine[0];
                var orderedProduct = orderLine[1];
                var orderedProductQuant = int.Parse(orderLine[2]);

                if (menuDictionary.ContainsKey(orderedProduct))
                {
                    var customer = new Customer();
                    customer.Name = customerName;

                    if (customers.Any(c => c.Name == customerName))
                    {
                        customer = customers.First(c => c.Name == customerName);

                        if (!customer.ShopList.ContainsKey(orderedProduct))
                        {
                            customer.ShopList[orderedProduct] = orderedProductQuant;
                            customer.Bill += orderedProductQuant * menuDictionary[orderedProduct];
                        }
                        else
                        {
                            customer.ShopList[orderedProduct] += orderedProductQuant;
                            customer.Bill += orderedProductQuant * menuDictionary[orderedProduct];
                        }
                    }
                    else
                    {
                        customer.ShopList = new Dictionary<string, int>();

                        customer.ShopList[orderedProduct] = orderedProductQuant;
                        customer.Bill = orderedProductQuant * menuDictionary[orderedProduct];
                        customers.Add(customer);
                    }
                }

                orderLine = Console.ReadLine().Split('-', ',');
            }

            var sum = 0m;
            foreach (var cust in customers.OrderBy(cl => cl.Name))
            {
                Console.WriteLine(cust.Name);

                foreach (var kvp in cust.ShopList)
                {
                    var product = kvp.Key;
                    var quantity = kvp.Value;
                    Console.WriteLine($"-- {product} - {quantity}");
                }
                Console.WriteLine($"Bill: {cust.Bill:F2}");

                sum += cust.Bill;
            }
            Console.WriteLine($"Total bill: {sum:F2}");
        }
    }
}
