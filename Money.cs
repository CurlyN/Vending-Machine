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
    public partial class Money : Form
    {
        Form form;
        public MoneyType[] coins_inserted = new MoneyType[8];
        public double money_inserted = 0;

        public Money(Form form1)
        {
            this.form = form1;

            InitializeComponent();
            money_inserted = 0;

            coins_inserted[0] = new MoneyType(0.01, 0);
            coins_inserted[1] = new MoneyType(0.02, 0);
            coins_inserted[2] = new MoneyType(0.05, 0);
            coins_inserted[3] = new MoneyType(0.1, 0);
            coins_inserted[4] = new MoneyType(0.2, 0);
            coins_inserted[5] = new MoneyType(0.5, 0);
            coins_inserted[6] = new MoneyType(1, 0);
            coins_inserted[7] = new MoneyType(2, 0);

        }

        //Each button of coin is additing the coin to the array of money
        private void one_p_Click(object sender, EventArgs e)
        {
            coins_inserted[0].Unit++;
            money_inserted = sumCoins(coins_inserted);
            moneyInserted.Text = "£  " + money_inserted;

        }

        //the button doing the same as the previous coin's button
        private void two_p_Click(object sender, EventArgs e)
        {
            coins_inserted[1].Unit++;
            money_inserted = sumCoins(coins_inserted);
            moneyInserted.Text = "£  " + money_inserted;
        }

        //the button doing the same as the previous coin's button
        private void five_p_Click(object sender, EventArgs e)
        {
            coins_inserted[2].Unit++;
            money_inserted = sumCoins(coins_inserted);
            moneyInserted.Text = "£  " + money_inserted;
        }

        //the button doing the same as the previous coin's button
        private void ten_p_Click(object sender, EventArgs e)
        {
            coins_inserted[3].Unit++;
            money_inserted = sumCoins(coins_inserted);
            moneyInserted.Text = "£  " + money_inserted;
        }

        //the button doing the same as the previous coin's button
        private void twenty_p_Click(object sender, EventArgs e)
        {
            coins_inserted[4].Unit++;
            money_inserted = sumCoins(coins_inserted);
            moneyInserted.Text = "£  " + money_inserted;
        }

        //the button doing the same as the previous coin's button
        private void fifty_p_Click(object sender, EventArgs e)
        {
            coins_inserted[5].Unit++;
            money_inserted = sumCoins(coins_inserted);
            moneyInserted.Text = "£  " + money_inserted;
        }

        //the button doing the same as the previous coin's button
        private void one_pound_Click(object sender, EventArgs e)
        {
            coins_inserted[6].Unit++;
            money_inserted = sumCoins(coins_inserted);
            moneyInserted.Text = "£  " + money_inserted;
        }

        //the button doing the same as the previous coin's button
        private void two_pounds_Click(object sender, EventArgs e)
        {
            coins_inserted[7].Unit++;
            money_inserted = sumCoins(coins_inserted);
            moneyInserted.Text = "£  " + money_inserted;
        }

        

        //the button is closing the current form
        private void insert_Click(object sender, EventArgs e)
        {
            money_inserted = sumCoins(coins_inserted);
            moneyInserted.Text = " £ " + 0;
            this.Close();
           
        }

        //The button is deleting the amount of money that the user wants to put in the machine
        private void delete_Click(object sender, EventArgs e)
        {
            moneyInserted.Text = " £ " + 0;
            money_inserted = 0;
        }

      
        //counting the overall amount of money being iserted
        public double sumCoins(MoneyType[] coins)
        {
            double sum = 0;
            for (int i=0; i<coins.Length;i++)
            {
                if (coins[i].Unit!=0)
                {
                    sum += coins[i].Value;
                }
            }
            return sum;
        }
    }
}
