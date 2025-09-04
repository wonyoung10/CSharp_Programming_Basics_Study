using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            int ivalue = 100;
            lbResult.Text = ivalue.ToString();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double fValue = 3.14;
            lbResult.Text = fValue.ToString(); 
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string sValue = "함수값";
            lbResult.Text = sValue;
        }
    }
}
