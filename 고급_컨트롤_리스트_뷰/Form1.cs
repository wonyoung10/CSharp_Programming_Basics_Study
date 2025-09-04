namespace 고급_컨트롤_리스트_뷰
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbOrg.Text == "")
            {
                MessageBox.Show("입력하지 않은 곳을 채워주세요.");
            }
            else
            {
                String[] strArray = new string[] { tbName.Text, tbPhone.Text, tbOrg.Text };
                ListViewItem lvt = new ListViewItem(strArray);
                listView1.Items.Add(lvt);
                tbName.Clear();
                tbPhone.Clear();  
                tbOrg.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = listView1.FocusedItem.Index;
            listView1.Items.RemoveAt(selectedIndex);
        }
    }
}
