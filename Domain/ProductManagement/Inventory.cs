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

        public List<Product> GetAllProducts()
        {
            return new List<Product>(products);
        }
    }
}
