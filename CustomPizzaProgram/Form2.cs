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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Cancel Button
        private void button1_Click(object sender, EventArgs e)
        {
            AllForms.cart = new List<string>();
            AllForms.cartPrices = new List<double>();
            // Send back to the first form
            AllForms.form2.Hide();
        }

        // Add to Cart Button
        private void button2_Click(object sender, EventArgs e)
        {

            // Store info of current pizza
            CheckBox[] options =
            {
                cbCheese, cbRegular, cbSmall, cbMed, cbLarge,
                cbPep, cbGP, cbBacon
            };
            foreach(CheckBox option in options)
            {
                if (option.Checked)
                {
                    AllForms.cart.Add(option.Text);
                    switch (option.Text)
                    {
                        case "Cheese Filled ($2.00)":
                            AllForms.cartPrices.Add(2.00);
                            break;
                        case "Regular ($1.00)":
                            AllForms.cartPrices.Add(1.00);
                            break;
                        case "Pepperoni ($0.50)":
                            AllForms.cartPrices.Add(0.50);
                            break;
                        case "Green Pepper ($0.50)":
                            AllForms.cartPrices.Add(0.50);
                            break;
                        case "Bacon ($0.50)":
                            AllForms.cartPrices.Add(0.50);
                            break;
                        case "Small ($5)":
                            AllForms.cartPrices.Add(5.00);
                            AllForms.pizzasOrdered++;
                            break;
                        case "Medium ($7)":
                            AllForms.cartPrices.Add(7.00);
                            AllForms.pizzasOrdered++;
                            break;
                        case "Large ($9)":
                            AllForms.cartPrices.Add(9.00);
                            AllForms.pizzasOrdered++;
                            break;
                        default:
                            break;
                    }
                    // Empty all checkboxes
                    option.Checked = false;
                }
            }
            


        }
        
        // View Cart Button
        private void button3_Click(object sender, EventArgs e)
        {
            // Display the third form
            AllForms.form3.Show();
        }
    }
}
