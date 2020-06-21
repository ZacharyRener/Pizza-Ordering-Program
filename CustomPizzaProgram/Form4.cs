using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomPizzaProgram
{
    public partial class Form4 : Form
    {

        public double totalOwed;

        public Form4()
        {
            InitializeComponent();
        }

        // Cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            AllForms.cart = new List<string>();
            AllForms.cartPrices = new List<double>();
            // Takes back to the first form
            AllForms.form2.Hide();
            AllForms.form3.Hide();
            AllForms.form4.Hide();
        }

        // Add another pizza button
        private void button2_Click(object sender, EventArgs e)
        {
            // Takes to the second form
            AllForms.form4.Hide();
            AllForms.form3.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Thanks the user for their oder
            MessageBox.Show("Your order has been placed! Thank you!!");
            // Returns to the first form
            AllForms.form2.Hide();
            AllForms.form3.Hide();
            AllForms.form4.Hide();
        }

        private void Form4_Activated(object sender, System.EventArgs e)
        {
            lblPizzasOrdered.Text = AllForms.pizzasOrdered + "";
            double totalCost = 0;
            foreach(double price in AllForms.cartPrices)
            {
                totalCost += price;
            }
            double tax = totalCost * 0.0865;
            lblAmountOfTax.Text = tax + "";
            lblDeliveryCharges.Text = "5.00";
            totalOwed = totalCost + tax + 5.00;
            lblTotalOwed.Text = totalOwed + "";
        }

        // Add a tip
        private void button4_Click(object sender, EventArgs e)
        {
            lblTotalOwed.Text = (totalOwed + Double.Parse(txtTip.Text)) + "";
        }
    }
}
