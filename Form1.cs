using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vending_Machine
{
    public partial class Form1 : Form
    {
        Money insert_money;
        Service_mode service1;
        public Product[] product = new Product[6];//the array of products that machine has
        public double money_inserted = 0;//the amount of money that has been inserted by user
        public MoneyType[] change = new MoneyType[8];//array for change coins
        int type; // profuct type 
        
        public Form1()
        {
            InitializeComponent();
            
            type = 0;
            insert_money = new Money(this);
            service1 = new Service_mode(product, change);

            //initialising product array
            product[0] = new Product(4, 0.5, "Coke");
            product[1] = new Product(4, 0.5, "Sprite");
            product[2] = new Product(4, 0.4, "Mirinda");
            product[3] = new Product(4, 0.4, "Pepsi");
            product[4] = new Product(4, 0.65, "Schweppes");
            product[5] = new Product(4, 0.65, "Mountain Dew");

            //initialising the change array
            change[0] = new MoneyType(0.01, 4);
            change[1] = new MoneyType(0.02, 4);
            change[2] = new MoneyType(0.05, 4);
            change[3] = new MoneyType(0.1, 4);
            change[4] = new MoneyType(0.2, 4);
            change[5] = new MoneyType(0.5, 4);
            change[6] = new MoneyType(1, 4);
            change[7] = new MoneyType(2, 4);
        }


        //choosing the product
        private void Coke_Click(object sender, EventArgs e)
        {
            //each product has its own type. Here we initialising the type of the product
            type = 0;
            //if we don't have this item in our store, saying that otherwise working correctly
            if (product[type].Unit > 0)
            {
                 
                textBox1.Text = " " + product[type].Name + ": " + +product[type].Price;
            }
            else
            {
                textBox1.Text = " There are no items " + product[type].Name + " left";
            }

        }

        //the same algorithm as for other items
        private void Pepsi_Click(object sender, EventArgs e)
        {
            type = 3;
            if (product[type].Unit > 0)
            {
                 
                textBox1.Text = " " + product[type].Name + ": " + +product[type].Price;
            }
            else
            {
                textBox1.Text = " There are no items " + product[type].Name + " left";
            }

        }

        //the same algorithm as for other items
        private void Sprite_Click(object sender, EventArgs e)
        {
            type = 1;
            if (product[type].Unit > 0)
            {
                 
                textBox1.Text = " " + product[type].Name + ": " + +product[type].Price;
            }
            else
            {
                textBox1.Text = " There are no items " + product[type].Name + " left";
            }
        }

        //the same algorithm as for other items
        private void Schweppes_Click(object sender, EventArgs e)
        {
            type = 4;
            if (product[type].Unit > 0)
            {
                 
                textBox1.Text = " " + product[type].Name + ": " + +product[type].Price;
            }
            else
            {
                textBox1.Text = " There are no items " + product[type].Name + " left";
            }
        }

        //the same algorithm as for other items
        private void Mirinda_Click(object sender, EventArgs e)
        {
            type = 2;
            if (product[type].Unit > 0)
            {
                 
                textBox1.Text = " " + product[type].Name + ": " + product[type].Price;
            }
            else
            {
                textBox1.Text = " There are no items " + product[type].Name + " left";
            }
        }

        //the same algorithm as for other items
        private void Mountain_Click(object sender, EventArgs e)
        {
            type = 5;
            if (product[type].Unit > 0)
            {
                 
                textBox1.Text = " " + product[type].Name + ": " + product[type].Price;
            }
            else
            {
                textBox1.Text = " There are no items " + product[type].Name + " left";
            }
        }


        //button for buying product
        private void buy_Click(object sender, EventArgs e)
        {
            showChange.Text = "";
            //checking if user has chosen the item. If no, warning him
            if (product[type] != null)
            {
                //constrains if amount of money is enough for buying product 
                if (money_inserted >= product[type].Price)
                {
                    //if everything is ok, we redusing the amount of chosen items in our store
                    product[type].Unit--;

                    //and calculate the amount of money that left 
                    money_inserted -= product[type].Price;

                    warning.Text = "You have biught 1 " + product[type].Name;
                    //giving change if user inserted more money than product's price
                    giveChange(change, money_inserted);
                    type = 0;
                    money_inserted = 0;
                   
                }
                else
                {
                    warning.Text = "Insufficient funds. You need to insert: " + (product[type].Price - money_inserted) + " pounds";
                }
            }
            else
            {
                warning.Text = "Product is not selected. You need to choose product";
            }
        }

        //button to insert money to the machine
        private void button2_Click(object sender, EventArgs e)
        {
            insert_money.ShowDialog();
            money_inserted = insert_money.money_inserted;
            moneyInserted.Text = " £ " + money_inserted;
            for (int i=0; i<insert_money.coins_inserted.Length;i++)
            {
                change[i].Unit += insert_money.coins_inserted[i].Unit;
            }

        }
        //the button is calling the giveChange method that provides creturning money that were inserted to the user
        private void button1_Click(object sender, EventArgs e)
        {
            showChange.Text = " ";
            giveChange(change, money_inserted);
            money_inserted = 0;
        }

        //the button is opening the form of Service_mode and renew the product array
        private void service_Click(object sender, EventArgs e)
        {
            service1.ShowDialog();
            product = service1.product;
        }


        //algorithm to give change
        public void giveChange(MoneyType[] change, double money_inserted)
        {
            int mtype = change.Length - 1;
            //while we have sum to return, we giving change with the highest coin's vvalue that we have
            //and by minimum amount of coins.
            //thus, if, for example, we have £ 1.6 to give back, the change has to be: 
            //1 coin of one pound, 1 coin of 50 pence, 1 coinn of 10 pence
            while ((money_inserted > 0) && (mtype >= 0))
            {
                while ((change[mtype].Unit >= 0) && (money_inserted >= change[mtype].Value))
                {
                    showChange.Text += " 1 coin of £ " + change[mtype].Value + " given \r\n";
                    change[mtype].Unit--;
                    money_inserted -= change[mtype].Value;
                    money_inserted = Math.Round(money_inserted, 4);
                }

                mtype--;
            }
        }
    }


}
