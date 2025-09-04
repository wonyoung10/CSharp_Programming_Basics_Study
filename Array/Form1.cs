using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] array = new int[] { 0, 0, 0 };
        private void btnResult_Click(object sender, EventArgs e)
        {
            lblResult.Text = "배열 출력 : ";
            array[0] = int.Parse(tbInput1.Text);
            array[1] = int.Parse(tbInput2.Text);
            array[2] = int.Parse(tbInput3.Text);

            for (int i = 0; i < array.Length; i++)
            {
                lblResult.Text += array[i].ToString() + " ";
            }
        }
    }
}
