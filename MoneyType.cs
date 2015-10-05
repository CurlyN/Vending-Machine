using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class MoneyType
    {
        private double price;
        private int unit;

        public MoneyType(double v, int u)
        {
            this.price = v;
            this.unit = u;
        }

        public double Value
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

        
    }
}
