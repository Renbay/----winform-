using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Forms
{
    public partial class 忘記密碼 : Form
    {
        public 忘記密碼()
        {
            InitializeComponent();
        }

        private void 忘記密碼_Load(object sender, EventArgs e)
        {
            string account = txt帳號.Text;
            string username = txt姓名.Text;
            string phonenumber = txt電話.Text;
            string strSQL = "";
        }

        private void btn查詢_Click(object sender, EventArgs e)
        {
            string account = txt帳號.Text;
            string username = txt姓名.Text;
            string phonenumber = txt電話.Text;
            string strSQL = "";

            string connectionString = @"Data Source=LAPTOP-KD80G839\SQLEXPRESS;Initial Catalog=myhouse;Integrated Security=True";
            string query = "SELECT 密碼 FROM member WHERE 帳號 = @Account AND 姓名 = @Name AND 電話 = @Phone";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Account", txt帳號.Text);
                command.Parameters.AddWithValue("@Name", txt姓名.Text);
                command.Parameters.AddWithValue("@Phone", txt電話.Text);

                

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string password = reader["密碼"].ToString();
                            lbox回應訊息.Items.Add($"您的密碼為: {password} 請小心保管~");
                        }
                    }
                    else if ((txt帳號.Text == "") || (txt姓名.Text == "") || (txt電話.Text == ""))
                    {
                        lbox回應訊息.Items.Add("請確實輸入所有個人資料");
                    }
                    else
                    {
                        lbox回應訊息.Items.Add("找不到資料!請確認您的資料是否輸入錯誤");
                    }
                }
                catch (Exception ex)
                {
                    lbox回應訊息.Items.Add("Error: " + ex.Message);
                }

                
            }
     }

        private void btn返回登入畫面_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


        

}
