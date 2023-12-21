using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpsp_Click(object sender, EventArgs e)
        {

            decimal numberStudent = Convert.ToDecimal(txtnumberofToday.Text);
            decimal growRate = Convert.ToDecimal(txtannualrate.Text);
            decimal numberOfYear = Convert.ToDecimal(txtnumberofyears.Text);

            
            for(int i=0; i<numberOfYear; i++){
                numberStudent = numberStudent + (numberStudent * growRate);
            }

            decimal projectNumber= Math.Round(numberStudent);
            txtprojectedstudent.Text = projectNumber.ToString("");
            txtprojectedstudent.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
