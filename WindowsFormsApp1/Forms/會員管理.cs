using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Forms
{
    public partial class 會員管理 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        int DGV筆數 = 0;



        public 會員管理()
        {
            InitializeComponent();
        }

        private void 會員管理_Load(object sender, EventArgs e)
        {
            scsb.DataSource = @"LAPTOP-KD80G839\SQLEXPRESS";
            scsb.InitialCatalog = "myhouse";
            scsb.IntegratedSecurity = true;

            strDBConnectionString = scsb.ConnectionString.ToString();
        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from member where 姓名 like @SearchName";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", $"%{txt姓名.Text}%");
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                txt帳號.Text = (string)reader["帳號"];
                txt姓名.Text = (string)reader["姓名"];
                txt信箱.Text = (string)reader["信箱"];
                txt電話.Text = (string)reader["電話"];
                txt密碼.Text = (string)reader["密碼"];
                txt住址.Text = (string)reader["住址"];
                dtp生日.Value = (DateTime)reader["生日"]; 
                
            }
            else
            {
                MessageBox.Show("查無此人");
            }
            reader.Close();
            con.Close();
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            if ((txt姓名.Text != "") && (txt密碼.Text != "") && (txt電話.Text != "") && (txt信箱.Text != "") && (txt帳號.Text != ""))
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

        private void btn資料新增_Click(object sender, EventArgs e)
        {
            if ((txt帳號.Text != "") && (txt姓名.Text != "") && (txt信箱.Text != "") && (txt電話.Text != "") && (txt密碼.Text != "") && (txt住址.Text != ""))
            { 
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "insert into member values(@NewAccount, @NewName, @NewEmail, @NewPhone, @NewPassword, @NewAddress, @NewBirth)";
                SqlCommand cmd = new SqlCommand( strSQL, con);

                cmd.Parameters.AddWithValue("@NewAccount", txt帳號.Text);
                cmd.Parameters.AddWithValue("@NewName", txt姓名.Text);
                cmd.Parameters.AddWithValue("@NewEmail", txt信箱.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                cmd.Parameters.AddWithValue("@NewAddress", txt住址.Text);
                cmd.Parameters.AddWithValue("@NewBirth", dtp生日.Value);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料新增成功, {rows}列資料受影響");
            }
            else
            {
                MessageBox.Show("欄位資料不全");
            }
        }

        private void btn資料刪除_Click(object sender, EventArgs e)
        {
            string Account = "";
          
            
            if (txt帳號.Text != "")
            { 
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from member where 帳號=@DeleteAccount";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteAccount", txt帳號.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料已刪除\n {rows} 列資料受影響");
                清空欄位();
            }
        }

        void 清空欄位()
        { 
            txt帳號.Clear();
            txt姓名.Clear();
            txt信箱.Clear();
            txt電話.Clear();
            txt密碼.Clear();
            txt住址.Clear();
            dtp生日.Value = DateTime.Now;
        }


        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }

        void 產生會員資料欄位(string myAccount)
        { 
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from member where 帳號=@SearchAccount";
            SqlCommand cmd = new SqlCommand( strSQL, con);
            cmd.Parameters.AddWithValue("@SearchAccount", myAccount);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                txt帳號.Text = (string)reader["帳號"];
                txt姓名.Text = (string)reader["姓名"];
                txt信箱.Text = (string)reader["信箱"];
                txt電話.Text = (string)reader["電話"];
                txt密碼.Text = (string)reader["密碼"];
                txt住址.Text = (string)reader["住址"];
                dtp生日.Value = (DateTime)reader["生日"];
            }
            else
            {
                MessageBox.Show("查無此人");
            }

            reader.Close();
            con.Close();

        }

        private void btn顯示全部資料_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select top 100 * from member";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            { 
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGV筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數: {DGV筆數}");

                dgv會員資料列表.DataSource = dt;
            }

            reader.Close ();
            con.Close();
        }

        private void dgv會員資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
