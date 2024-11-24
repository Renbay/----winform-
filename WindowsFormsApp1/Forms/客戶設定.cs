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
using System.Data.SqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class 客戶設定 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        public 客戶設定()
        {
            InitializeComponent();
        }

        private void 客戶設定_Load(object sender, EventArgs e)
        {
            string LoginAccount = Globalvar.LoginAccount;

            scsb.DataSource = @"LAPTOP-KD80G839\SQLEXPRESS"; //伺服器名稱
            scsb.InitialCatalog = "myhouse"; //資料庫名稱
            scsb.IntegratedSecurity = true; //Windsows驗證: true

            strDBConnectionString = scsb.ConnectionString.ToString();

            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = $"select * from member where 帳號='{LoginAccount}'";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read() == true)
            {
                txt姓名.Text = (string)reader["姓名"];
                txt住址.Text = (string)reader["住址"];
                txt信箱.Text = (string)reader["信箱"];
                txt密碼.Text = (string)reader["密碼"];
                txt帳號.Text = (string)reader["帳號"];
                txt電話.Text = (string)reader["電話"];
                dtp生日.Value = (DateTime)reader["生日"];
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt密碼.Text != "") && (txt電話.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update member set 姓名=@NewName, 信箱=@NewEmail, 電話=@NewPhone, 密碼=@NewPassword, 住址=@NewAddress, 生日=@NewBirth where 帳號=@SearchAccount ";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchAccount", txt帳號.Text);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txt信箱.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt住址.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料修改成功, {rows}列資料受影響");
            }
            else
            {
                MessageBox.Show("資料提供不全");
            }
        }
        
    }
}

