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
            Console.WriteLine("Not Implemented");
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
