using System.IO;
namespace FileEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileCopy_Click(object sender, EventArgs e)
        {
            string path = @"C:\wy.txt";
            try
            {
                if (File.Exists(path))
                {
                    File.Copy(path, @"C:\wy_����.txt");
                    File.Copy(path, @"C:\wy_����.txt");
                    lbFileInfo.Items.Clear();
                    lbFileInfo.Items.Add("���簡 �Ϸ� �Ǿ����ϴ�.");
                }
            }
            catch (Exception)
            {
                lbFileInfo.Items.Clear();
                lbFileInfo.Items.Add("�̹� ������ �ֽ��ϴ�.");
            }


        }

        private void btnFileInfo_Click(object sender, EventArgs e)
        {
            FileInfo fInfo = new FileInfo(@"C:\wy.txt");
            if (fInfo.Exists)
            {
                lbFileInfo.Items.Clear();
                lbFileInfo.Items.Add("���� �̸� : " + fInfo.Directory);
                lbFileInfo.Items.Add("���� �̸� : " + fInfo.Name);
                lbFileInfo.Items.Add("Ȯ���� : " + fInfo.Extension);
                lbFileInfo.Items.Add("������ : " + fInfo.CreationTime);
                lbFileInfo.Items.Add("���� ũ�� : "+ fInfo.Length);
            }
            

            
        }
    }
}
