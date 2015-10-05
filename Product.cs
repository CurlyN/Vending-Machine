using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class Product
    {
        private int unit;
        private double price;
        private string name;

        public Product(int u, double p, string n)
        {
            this.unit = u;
            this.price = p;
            this.name = n;
        }

        public int Unit
        {
            get
            {
                return unit;
            }
            set
            {
                unit = value;
            }
        }


        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
