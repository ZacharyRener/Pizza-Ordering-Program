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


    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        // Cancel Button
        private void button1_Click(object sender, EventArgs e)
        {
            AllForms.cart = new List<string>();
            AllForms.cartPrices = new List<double>();
            // Takes back to the first form
            AllForms.form2.Hide();
            AllForms.form3.Hide();
        }

        // Add another pizza button
        private void button2_Click(object sender, EventArgs e)
        {
            // Takes back to the second form
            AllForms.form3.Hide();
        }

        // Checkout Button
        private void button3_Click(object sender, EventArgs e)
        {
            // Takes to the fourth form
            AllForms.form4.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //loadCart();
        }

        private void Form3_Activated(object sender, System.EventArgs e)
        {
            loadCart();
        }

        void loadCart()
        {
            this.lbCart.Items.Clear();
            foreach (string item in AllForms.cart)
            {
                this.lbCart.Items.Add(item);
            }
        }
    }
}
