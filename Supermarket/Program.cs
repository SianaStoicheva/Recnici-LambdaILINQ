using System.Globalization;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supermarket supermarket = new Supermarket();
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "stocked")
                    break;

                string[] parts = input.Split();
                string name = parts[0];
                decimal price = decimal.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);

                supermarket.AddOrUpdateProduct(name, price, quantity);
            }

            supermarket.PrintInventory();
        }
    }
}
