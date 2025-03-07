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
            Console.WriteLine("Not Implemented");
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
