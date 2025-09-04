using System.IO;
namespace directoryinfo_실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDirInfo_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Windows");
            if (dirInfo.Exists)
            {
                lbDirInfo.Items.Add("전체경로 : " + dirInfo.FullName);
                lbDirInfo.Items.Add("디렉터리 이름 : " + dirInfo.Name);
                lbDirInfo.Items.Add("생성일 : " + dirInfo.CreationTime);
                lbDirInfo.Items.Add("속성 : " + dirInfo.Attributes);
                lbDirInfo.Items.Add("루트 : " + dirInfo.Root);
            }
        }
    }
}
