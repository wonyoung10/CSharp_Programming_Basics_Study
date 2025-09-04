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
            LoadData(); // MySQL 데이터를 불러오는 함수
        }

        private void LoadData()
        {
            string connectionString = "Server=33060;Database=mysql_db;User ID=mysql;Password=mysql;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM T_NUMBER"; // users 테이블에서 데이터 가져오기

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            listView1.Items.Clear(); // 기존 데이터 초기화
                            listView1.View = View.Details;
                            listView1.Columns.Clear();
                            listView1.Columns.Add("ID", 100);
                            listView1.Columns.Add("Name", 200);

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["id"].ToString());
                                item.SubItems.Add(reader["name"].ToString());
                                listView1.Items.Add(item); // ListView에 데이터 추가
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("오류 발생: " + ex.Message);
                }
            }
        }

        private void ctrButton_Insert_Click(object sender, EventArgs e)
        {
            InsertData("");
        }
    }
}
