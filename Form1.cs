using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button0.Text;
            lblTotal.Text += button0.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button1.Text;
            lblTotal.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button2.Text;
            lblTotal.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button3.Text;
            lblTotal.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button4.Text;
            lblTotal.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button5.Text;
            lblTotal.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button6.Text;
            lblTotal.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button7.Text;
            lblTotal.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button8.Text;
            lblTotal.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text += button9.Text;
            lblTotal.Text += button9.Text;
        }

       
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Clear();
            lblTotal.Text = "";
        }

        
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            lblTotal.Text += buttonDecimal.Text;
            txtboxDisplay.Text += buttonDecimal.Text;
        }

   

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            lblTotal.Text += buttonPlus.Text;
            txtboxDisplay.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            lblTotal.Text += buttonMinus.Text;
            txtboxDisplay.Clear();
    
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            lblTotal.Text += "*";
            txtboxDisplay.Clear();
  
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            lblTotal.Text += buttonDivision.Text;
            txtboxDisplay.Clear();

        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            var finalTotal = dt.Compute(lblTotal.Text, "");
            txtboxDisplay.Text = finalTotal.ToString();

           
        }

    }
}
