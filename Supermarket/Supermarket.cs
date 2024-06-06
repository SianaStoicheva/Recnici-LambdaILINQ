using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Supermarket
    {
        private Dictionary<string, Product> products;

        public Supermarket()
        {
            products = new Dictionary<string, Product>();
        }

        public void AddOrUpdateProduct(string name, decimal price, int quantity)
        {
            if (products.ContainsKey(name))
            {
                var existingProduct = products[name];
                existingProduct.Quantity += quantity;
                existingProduct.Price = price;
            }
            else
            {
                var newProduct = new Product(name, price, quantity);
                products.Add(name, newProduct);
            }
        }

        public void PrintInventory()
        {
            decimal grandTotal = 0;
            foreach (var product in products.Values)
            {
                decimal totalPrice = product.TotalPrice();
                grandTotal += totalPrice;
                Console.WriteLine($"{product.Name}: ${product.Price:f2} * {product.Quantity} = ${totalPrice:f2}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }
    }
}
