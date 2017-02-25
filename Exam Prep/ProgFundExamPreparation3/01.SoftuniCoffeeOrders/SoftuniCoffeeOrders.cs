namespace _01.SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            var numberOfOrders = int.Parse(Console.ReadLine());
            var totalPrice = 0.0m;

            for (int i = 0; i < numberOfOrders; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = int.Parse(Console.ReadLine());

                var orderPrice = pricePerCapsule * capsulesCount * (DateTime.DaysInMonth(orderDate.Year, orderDate.Month));
                totalPrice += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
