using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
           for (int i=1;i<10;i++)
            {
                lblResult.Text += tbDan.Text + "*" + i.ToString()
                + " = " + int.Parse(tbDan.Text) * i + Environment.NewLine;
            } 
        }
    }
}
