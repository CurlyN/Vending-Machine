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
    public partial class Service_mode : Form
    {
        // Form1 form;

       
        Money money;
        public Product[] product;
        public MoneyType[] change;
        int type;

        public Service_mode(Product[] product1,MoneyType[] change1)
        {
            Form1 frm = (Form1)this.Owner;
            money = new Money(this); 
            InitializeComponent();
            this.product = product1;
            this.change = change1;


        }

        //The method is tacking information from arrays of Product and Change and show it im textboxes
        private void getInfo_Click(object sender, EventArgs e)
        {
            listOfItems.Text = "   ";
            listOfChange.Text = "   ";
            for (int i = 0; i < product.Length; i++)
            {
                listOfItems.Text += product[i].Name + ": " + product[i].Unit + " items left \r\n";
            }

            for (int i = 0; i < change.Length; i++)
            {
                listOfChange.Text += " £ " + change[i].Value + ": " + change[i].Unit + " items left \r\n";
            }


        }

        //each button of item showing in textbox the item chosen and setting the type of current chosen product
        private void Coke_Click(object sender, EventArgs e)
        {
            type = 0;
            showItem.Text = "Item " + product[type].Name + " chosen";
        }

        // The Add button is increasing the amount of chosen product and showing the feedback for the user
        private void Add_Click(object sender, EventArgs e)
        {
            product[type].Unit++;
            showItem.Text = "Item " + product[type].Name + " added";
        }

        //The Delete button is doing the opposite to Add button and provide the feedback for user as well
        private void Delete_Click(object sender, EventArgs e)
        {
            //Before deletion of the product we need to check first are there any items left to delete it
            if (product[type].Unit>0)
            {
                product[type].Unit--;
                showItem.Text = "Item " + product[type].Name + " deleted";
            }
            else
            {
                showItem.Text = "There are no items to delete";
            }
        }

        //the button doing the same work as previous item button
        private void Pepsi_Click(object sender, EventArgs e)
        {
            type = 3;
            showItem.Text = "Item " + product[type].Name + " chosen";
        }

        //the button doing the same work as previous item button
        private void Sprite_Click(object sender, EventArgs e)
        {
            type = 1;
            showItem.Text = "Item " + product[type].Name + " chosen";
        }

        //the button doing the same work as previous item button
        private void Mirinda_Click(object sender, EventArgs e)
        {
            type = 2;
            showItem.Text = "Item " + product[type].Name + " chosen";
        }

        //the button doing the same work as previous item button
        private void Mountain_Click(object sender, EventArgs e)
        {
            type = 5;
            showItem.Text = "Item " + product[type].Name + " chosen";
        }

        //the button doing the same work as previous item button
        private void Schweppes_Click(object sender, EventArgs e)
        {
            type = 4;
            showItem.Text = "Item " + product[type].Name + " chosen";
        }

        //The button is resposible for additing the change array. It calls the Money.cs form 
        //and add all item that has been changed there in change array of current form
        private void button2_Click(object sender, EventArgs e)
        {
            money.ShowDialog();
            for (int i=0;i<money.coins_inserted.Length;i++)
            {
                change[i].Unit += money.coins_inserted[i].Unit;
            }
        }

        //Simple button to close the form
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
