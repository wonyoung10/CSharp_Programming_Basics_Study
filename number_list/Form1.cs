using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace number_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); // MySQL �����͸� �ҷ����� �Լ�
        }

        private void LoadData()
        {
            string connectionString = "Server=33060;Database=mysql_db;User ID=mysql;Password=mysql;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM T_NUMBER"; // users ���̺��� ������ ��������

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            listView1.Items.Clear(); // ���� ������ �ʱ�ȭ
                            listView1.View = View.Details;
                            listView1.Columns.Clear();
                            listView1.Columns.Add("ID", 100);
                            listView1.Columns.Add("Name", 200);

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["id"].ToString());
                                item.SubItems.Add(reader["name"].ToString());
                                listView1.Items.Add(item); // ListView�� ������ �߰�
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("���� �߻�: " + ex.Message);
                }
            }
        }

        private void ctrButton_Insert_Click(object sender, EventArgs e)
        {
            InsertData("");
        }
    }
}
