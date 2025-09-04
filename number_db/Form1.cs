using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace number_db
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=127.0.0.1;Por=t33060;Database=mysql_db;User ID=mysql;Password=mysql";

        public Form1()
        {
            InitializeComponent();
            InitializeListView();  // ListView 초기화
            LoadData();  // 데이터 로딩
        }

        // ListView 초기화
        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("USER_PHONE", 120);
            listView1.Columns.Add("USER_NAME", 120);
            listView1.Columns.Add("USER_INSERT_TIME", 200);
            listView1.Columns.Add("USER_DESC", 200);
            listView1.Columns.Add("USER_UPDATE_TIME", 200);
        }

        // 데이터 삽입 메서드
        private void InsertData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"
                    INSERT INTO T_NUMBER (USER_PHONE, USER_NAME, USER_INSERT_TIME, USER_DESC, USER_UPDATE_TIME)
                    VALUES (@USER_PHONE, @USER_NAME, @USER_INSERT_TIME, @USER_DESC, @USER_UPDATE_TIME)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@USER_PHONE", "01012345678");
                        cmd.Parameters.AddWithValue("@USER_NAME", "홍길동");
                        cmd.Parameters.AddWithValue("@USER_INSERT_TIME", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@USER_DESC", "설명 예시");
                        cmd.Parameters.AddWithValue("@USER_UPDATE_TIME", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("데이터 삽입 완료!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        // 데이터 로드 메서드
        private void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
        SELECT 
            USER_PHONE, 
            USER_NAME, 
            USER_INSERT_TIME, 
            USER_DESC, 
            USER_UPDATE_TIME 
        FROM T_NUMBER"; // 적절한 테이블명으로 수정하세요.

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        listView1.Items.Clear(); // 기존 데이터 초기화
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["USER_PHONE"].ToString());
                            item.SubItems.Add(reader["USER_NAME"].ToString());
                            item.SubItems.Add(reader["USER_INSERT_TIME"].ToString());
                            item.SubItems.Add(reader["USER_DESC"].ToString());
                            item.SubItems.Add(reader["USER_UPDATE_TIME"].ToString());
                            listView1.Items.Add(item);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        // 예시: 버튼 클릭 이벤트로 InsertData() 호출


        private void insertButton_Click_1(object sender, EventArgs e)
        {
            InsertData();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newform2 = new Form2();
            newform2.ShowDialog();
        }
    }
}
