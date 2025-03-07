using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Domain.ProductManagement
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public bool RemoveProduct(string productName)
        {
            Product? product = FindProductByName(productName);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            return false;
        }

        public Product? FindProductByName(string name)
        {
            foreach (var product in products)
            {
                if (product.Name.Equals(name,StringComparison.OrdinalIgnoreCase))
                {
                    return product;
                }
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            return new List<Product>(products);
        }

    }
}
