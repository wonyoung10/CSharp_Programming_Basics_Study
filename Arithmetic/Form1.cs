using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtInput1.Text);
            int num2 = int.Parse(txtInput2.Text);
            int num3 = num1 + num2; 
            lblResult.Text = num3.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtInput1.Text);
            int num2 = int.Parse(txtInput2.Text);
            int num3 = num1 - num2;
            lblResult.Text = num3.ToString();
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtInput1.Text);
            int num2 = int.Parse(txtInput2.Text);
            int num3 = num1 * num2;
            lblResult.Text = num3.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtInput1.Text);
            int num2 = int.Parse(txtInput2.Text);
            int num3 = num1 / num2;
            lblResult.Text = num3.ToString();
        }
    }
}
