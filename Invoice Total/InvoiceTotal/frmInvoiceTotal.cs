using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            string CustomerType = txtCustomerType.Text;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0;

            if (CustomerType == "R" || CustomerType == "r")
            {
                if (subtotal >= 250 && subtotal < 500)
                {
                    discountPercent = .25m;
                }
                else if (subtotal >= 500)
                    discountPercent = .3m;
            }
            else if (CustomerType == "C" || CustomerType == "c")
            {
                discountPercent = .2m;
            }
            else if (CustomerType == "T" || CustomerType == "t")
            {
                if (subtotal < 500)
                    discountPercent = .4m;
                else
                    discountPercent = .5m;
            }
            else
            {
                discountPercent = .1m;
            }
            //Calculate invoiceTotal
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDicountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");
            txtCustomerType.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
