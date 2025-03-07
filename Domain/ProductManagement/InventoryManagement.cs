using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Domain.ProductManagement
{
    public class InventoryManager
    {
        public void DisplayMenu(Inventory inventory)
        {
            while (true)
            {
                Console.WriteLine("===== Simple Inventory Management System =====");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Edit Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Search Product");
                Console.WriteLine("6. Exit");

                string? choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(">>> Add a New Product <<<");
                        AddProduct(inventory); break;
                    case "2":
                        ViewProducts(inventory); break;
                    case "3":
                        EditProduct(inventory); break;
                    case "4":
                        DeleteProduct(inventory); break;
                    case "5":
                        SearchProduct(inventory); break;
                    case "6":
                        Console.WriteLine("Not implemented"); break;


                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        public void AddProduct(Inventory inventory)
        {
            string? name;
            double price;
            int quantity;
            do
            {
                Console.Write("Enter product name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The product name is required.");
                    Console.ResetColor();
                }
                else if (inventory.GetAllProducts().Any(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("A product with this name already exists. Please enter a unique name.");
                    Console.ResetColor();
                    name = null;
                }
            } while (string.IsNullOrWhiteSpace(name));

            while (true)
            {
                Console.Write("Enter product price: ");
                if (double.TryParse(Console.ReadLine(), out price) && price > 0)
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid price.");
                Console.ResetColor();
            }

            while (true)
            {
                Console.Write("Enter product quantity: ");
                if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                    break;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid quantity.");
                Console.ResetColor();
            }

            Product product = new Product(name, price, quantity);
            inventory.AddProduct(product);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Product added successfully!");
            Console.ResetColor();
        }

        public void ViewProducts(Inventory inventory)
        {
            List<Product> products = inventory.GetAllProducts();

            if (products.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("No products in inventory.");
                Console.ResetColor();
                return;
            }
            Console.WriteLine("All Products:");

            Console.WriteLine(new string('=', 50));
            Console.WriteLine("| {0,-20} | {1,10} | {2,10} |", "Name", "Price", "Quantity");
            Console.WriteLine(new string('=', 50));

            for (int i = 0; i < products.Count; i++)
            {
                Product product = products[i];
                Console.WriteLine("| {0,-20} | {1,10:C} | {2,10} |", product.Name, product.Price, product.Quantity);

                if (i < products.Count - 1)
                {
                    Console.WriteLine(new string('-', 50));
                }
            }

            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"Total Products: {products.Count}\n");

            Console.WriteLine("Press Enter to go back...");
            Console.ReadLine();
            Console.Clear();
        }

        public void EditProduct(Inventory inventory)
        {
            Console.WriteLine("Not Implemented");
        }

        public void DeleteProduct(Inventory inventory)
        {
            Console.WriteLine("Not Implemented");
        }

        public void SearchProduct(Inventory inventory)
        {
            Console.WriteLine("Not Implemented");
        }
    }
}
