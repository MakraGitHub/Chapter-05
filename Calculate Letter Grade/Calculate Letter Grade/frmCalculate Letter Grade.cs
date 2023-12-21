using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Letter_Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCLG_Click(object sender, EventArgs e)
        {
            decimal letterGrade = Convert.ToDecimal(txtnummeric.Text);

            //Make letter grade 

            if (letterGrade >= 90 && letterGrade < 100)
            {
                txtLetter.Text = "A";
            }

            else if (letterGrade >= 80 && letterGrade < 89)
            {
                txtLetter.Text = "B";
            }

            else if (letterGrade >= 70 && letterGrade < 79)
            {
                txtLetter.Text = "C";
            }

            else if (letterGrade >= 60 && letterGrade < 69)
            {
                txtLetter.Text = "D";
            }
            else
            {
                txtLetter.Text = "F";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
