using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conditional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int kuk = int.Parse(tbKuk.Text);
            int eng = int.Parse(tbEng.Text);
            int math = int.Parse(tbMath.Text);
            int total = kuk + eng + math;
            int avg = total / 3;
            lblAvg.Text = avg.ToString();
            switch(avg/10)
            {
                case 10:
                case 9:
                    lblResult.Text = "A학점";
                    break;
                case 8:
                    lblResult.Text = "B학점";
                    break;
                case 7:
                    lblResult.Text = "C학점";
                    break;
                case 6:
                    lblResult.Text = "D학점";
                    break;
                default:
                    lblResult.Text = "F학점";
                    break;
            }
            
        }
    }
}
