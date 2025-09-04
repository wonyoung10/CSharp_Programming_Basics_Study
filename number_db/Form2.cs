using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace number_db
{
    public partial class Form2 : Form
    {
        // 이벤트 선언
        
        private string connectionString = "Server=127.0.0.1;Port=33060;Database=mysql_db;User ID=mysql;Password=mysql";

        public Form2()
        {
            InitializeComponent();
        }


        private void InsertData()
        {
            
        }
            private void button1_Click(object sender, EventArgs e)
        {
            string u_name, u_phone, u_desc, u_idx;
            
            u_name = tb_name.Text;
            u_phone = tb_phone.Text;
            u_desc = tb_desc.Text; 
            u_idx = tb_idx.Text;
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
                        cmd.Parameters.AddWithValue("@USER_PHONE", u_phone);
                        cmd.Parameters.AddWithValue("@USER_NAME", u_name);
                        cmd.Parameters.AddWithValue("@USER_INSERT_TIME", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmd.Parameters.AddWithValue("@USER_DESC", u_desc);
                        cmd.Parameters.AddWithValue("@USER_UPDATE_TIME", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                        cmd.ExecuteNonQuery();
                    }
                }

                //MessageBox.Show("데이터 삽입 완료!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류 발생: " + ex.Message);
            }


            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
