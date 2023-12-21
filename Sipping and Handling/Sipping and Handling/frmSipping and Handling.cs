using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipping_and_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btncalcualtegrandetotal_Click(object sender, EventArgs e)
        {

            double orderTotal = Convert.ToDouble(txtorder.Text);
            string customerType= txtCustomerType.Text;
            double shipping = 0;
            double saleTax = 0;

            if (customerType == "P" || customerType == "p")
            {
                shipping = 0;
            }
            else if (customerType == "N" || customerType == "n")
            {
                if (orderTotal < 25)
                {
                    shipping = 5;
                }
                else if (orderTotal > 25.01 && orderTotal <= 500)
                {
                    shipping = 8;
                }
                else if(orderTotal > 500.01 && orderTotal <= 1000.00)
                {
                    shipping = 10;
                }
                else if (orderTotal > 1000.01 && orderTotal <= 5000.00)
                {
                    shipping = 15;
                }
                else
                {
                    shipping = 20;
                }
            }
            //Calculate saleTax (7%)
            saleTax = orderTotal * 7 / 100;

            //Calculate grade total 
            double grandTotal = orderTotal + shipping + saleTax;

            //Display the shipping  cost, saleTax and granTotal formmatted to currency ($)
            txtsaletax.Text = saleTax.ToString("c");
            txtSpping.Text = shipping.ToString("c");
            txtgradetotal.Text = grandTotal.ToString("c");
            txtCustomerType.Text = customerType.ToString();

            txtCustomerType.Focus();
        }


        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    }
}
