using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class 註冊畫面 : Form
    {
        public 註冊畫面()
        {
            InitializeComponent();
        }

        private void 註冊畫面_Load(object sender, EventArgs e)
        {

        }

        private void btn確認註冊_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string account = txt帳號.Text;
            string password = txt密碼.Text;
            string chkpassword = txt確認密碼.Text;
            string name = txt姓名.Text;
            string phonenumber = txt電話.Text;
            DateTime birthday = dtp生日.Value;
            string address = txt住址.Text;
            string email = txt信箱.Text;
            string strSQL = "";
            SqlCommand command;

            string connectionString = @"Data Source=LAPTOP-KD80G839\SQLEXPRESS;Initial Catalog=myhouse;Integrated Security=True";

            if (account == "")
            {
                MessageBox.Show("帳號為必填資料!!");
                return;
            }
            if (password == "")
            {
                MessageBox.Show("密碼為必填資料!!");
                return;
            }

            if (password != chkpassword)
            {
                MessageBox.Show("請確認您的兩組密碼是否一樣!!");
                return;
            }

            if (name == "")
            {
                MessageBox.Show("姓名為必填資料!!");
                return;
            }

            if (phonenumber == "")
            {
                MessageBox.Show("電話為必填資料!!");
                return;
            }

           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    strSQL = $"select * from member where 帳號='{account}' ";

                    command = new SqlCommand(strSQL, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }

                    if (dataTable.Rows.Count > 0)
                    {
                        MessageBox.Show("註冊失敗,此帳號已存在!!!");
                    }
                    else
                    {
                        strSQL = @"insert into member(帳號, 姓名, 信箱, 電話, 密碼, 住址, 生日) 
                                   values (@account, @name, @email, @phonenumber, @password, @address, @birthday)";
                        command = new SqlCommand(strSQL, connection);
                        command.Parameters.AddWithValue("@account", account);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@phonenumber", phonenumber);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@birthday", birthday);
                        command.ExecuteNonQuery();
                        MessageBox.Show("註冊成功!!!");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("登入失敗:" + ex.ToString());
                }
                finally
                { 
                    connection.Close(); 
                }
            }
        }
    }
}
