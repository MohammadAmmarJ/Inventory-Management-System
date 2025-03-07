using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System.Domain.ProductManagement
{
    public class Product
    {
        private string name { get; set; }
        private double price { get; set; }
        private int quantity { get; set; }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

    }
}
