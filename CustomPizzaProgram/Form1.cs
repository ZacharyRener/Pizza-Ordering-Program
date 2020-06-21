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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllForms.form2.Show();
        }
    }

    public static class AllForms
    {
        public static Form form1 = new Form1();
        public static Form form2 = new Form2();
        public static Form form3 = new Form3();
        public static Form form4 = new Form4();

        // Ability to have up to 100 items in the cart
        public static List<string> cart = new List<string>();
        public static List<double> cartPrices = new List<double>();
        // cart.Add(value);
        // foreach (string item in cart)

        public static int pizzasOrdered = 0;

    }
}
