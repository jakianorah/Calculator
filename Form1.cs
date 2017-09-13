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

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn0.Text;
            lblTotal.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn.Text;
            lblTotal.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn2.Text;
            lblTotal.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn3.Text;
            lblTotal.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn4.Text;
            lblTotal.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn5.Text;
            lblTotal.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn6.Text;
            lblTotal.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn7.Text;
            lblTotal.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn8.Text;
            lblTotal.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn9.Text;
            lblTotal.Text += btn9.Text;
        }

       
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            lblTotal.Text = "";
        }

        
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            lblTotal.Text += btnDecimal.Text;
            txtDisplay.Text += btnDecimal.Text;
        }

   

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            lblTotal.Text += btnPlus.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            lblTotal.Text += btnMinus.Text;
    
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            lblTotal.Text += btnMultiply.Text;
  
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            lblTotal.Text += btnDivision.Text;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            var finalTotal = dt.Compute(lblTotal.Text, "");
            txtDisplay.Text = finalTotal.ToString();

           
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string total1 = lblTotal.Text;
            string total2 = txtDisplay.Text;

            if (total1.Length > 1)
            {
                total1 = total1.Substring(0, total1.Length - 1);
                total2 = total2.Substring(0, total2.Length - 1);
            }
            else if (total1.Length ==1)
            {
                total1 = "";
                total2 = total2.Substring(0, total2.Length - 1);
            }
            else
            {
                //do nothing
            }


            lblTotal.Text = total1;
            txtDisplay.Text = total2;
        }
    }
}
