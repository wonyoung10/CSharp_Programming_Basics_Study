using System.ComponentModel;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace list_view
{
    public partial class list_view : Form
    {
        public list_view()
        {
            InitializeComponent();
        }

        private void list_view_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDirList_Click(object sender, EventArgs e)
        {
            lbDir.Items.Clear();
            string[] apaths = Directory.GetDirectories(Environment.SystemDirectory);

            foreach (string dirPath in apaths)
            {
                lbDir.Items.Add(dirPath+'\n');
            }
        }

        private void btnFileList_Click(object sender, EventArgs e)
        {
            lbFiles.Items.Clear();
            string[] afiles = Directory.GetFiles(Environment.SystemDirectory,"*.exe");
            foreach (string file in afiles) 
            {
                lbFiles.Items.Add(file);
            }

        }
    }
}
