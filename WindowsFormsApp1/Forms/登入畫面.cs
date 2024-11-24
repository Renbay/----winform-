using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1.Forms
{
    public partial class 登入畫面 : Form
    {
        private bool isPasswordVisible = false;
        public 登入畫面()
        {
            InitializeComponent();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable(); //把TABLE資料讀進來這
            string account = txt帳號.Text;
            string password = txt密碼.Text;

            string strSQL = "";

            string connectionString = @"Data Source=LAPTOP-KD80G839\SQLEXPRESS;Initial Catalog=myhouse;Integrated Security=True"; //DB連線

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    strSQL = $"select * from member where 帳號='{account}' and 密碼='{password}' ";// SQL

                    SqlCommand command = new SqlCommand(strSQL, connection); //下SQL去撈資料瞜
                    using (SqlDataReader reader = command.ExecuteReader()) //把資料read到table
                    {
                        dataTable.Load(reader);
                    }

                    if (dataTable.Rows.Count > 0) //有撈到一筆表示此會員資料存在
                    {
                        Globalvar.LoginAccount = account;
                        Globalvar.LogName = dataTable.Rows[0]["姓名"].ToString();                       

                        高雄房屋資訊系統 mainForm = new 高雄房屋資訊系統();
                        mainForm.Show();
                        this.Hide();
                        
                    }
                    else if (account == "manager123" && password == "manager123")
                    {
                        管理者介面 mainForm = new 管理者介面();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("登入失敗, 請檢查您的帳號或密碼!!!");
                    }
                }
                catch (Exception ex) //如有錯誤就跑來這並輸出錯誤訊息(ex)
                {
                    MessageBox.Show("登入失敗:" + ex.Message.ToString());
                }

                //if (account == "manager123" && password == "manager123")
                //{
                //    管理者介面 mainForm = new 管理者介面();
                //    mainForm.Show();
                //    this.Hide();
                //}
                //else
                //{
                //    MessageBox.Show("登入失敗，請檢查用戶名和密碼。");
                //}

            }
        }

        //void 會員資料讀取()
        //{
        //    try 
        //    {
        //        string line;
        //        StreamReader sr = new StreamReader(@"C:\Users\User\Desktop\個人專題-20240722T145554Z-001\會員資料\會員資料暫存.txt");
        //        line = sr.ReadLine();
        //        int.TryParse(line, out Globalvar.LogName);

        //    }        
        //}

        void 會員紀錄()
        {
            string str預設檔案 = @"C:\Users\User\Desktop\個人專題-20240722T145554Z-001\會員資料";
            string str檔名 = "會員資料暫存.txt";
            string str完整路徑檔名 = str預設檔案 + @"\" + str檔名;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = str預設檔案;
            sfd.FileName = str檔名;
            File.WriteAllText(str完整路徑檔名, Globalvar.LogName, Encoding.UTF8);
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            註冊畫面  my註冊畫面 = new 註冊畫面();
            my註冊畫面.ShowDialog();

        }

        private void btn忘記密碼_Click(object sender, EventArgs e)
        {
            忘記密碼 my忘記密碼 = new 忘記密碼();
            my忘記密碼 .ShowDialog();
        }

        private void btn訪客登入_Click(object sender, EventArgs e)
        {
            訪客介面 my訪客介面 = new 訪客介面();
            my訪客介面.ShowDialog();
        }

        private void 登入畫面_Load(object sender, EventArgs e)
        {

        }

        private void btnTogglePasswordVisibility_Click(object sender, EventArgs e)
        {
            // 切換密碼的可見性
            if (isPasswordVisible)
            {
                // 隱藏密碼
                txt密碼.PasswordChar = '*';
                btnTogglePasswordVisibility.Text = "😳"; // 眼睛符號
                isPasswordVisible = false;
            }
            else
            {
                // 顯示密碼
                txt密碼.PasswordChar = '\0';
                btnTogglePasswordVisibility.Text = "😎"; // 眼睛閉合符號
                isPasswordVisible = true;
            }
        }
    }
}
