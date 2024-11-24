using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WindowsFormsApp1.Forms
{
    public partial class 預約列表 : Form
    {
        public 預約列表()
        {
            InitializeComponent();
            dgv預約列表.DataSource = Globalvar.Housetable;
            
        }

        private void 預約列表_Load(object sender, EventArgs e)
        {
            dgv預約列表.AllowUserToAddRows = false;
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            if (dgv預約列表.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv預約列表.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgv預約列表.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除預約的資料");
            }
        }

        private void btn確定_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable(); //把TABLE資料讀進來這
            string LoginAccount = Globalvar.LoginAccount;
            string LogName = Globalvar.LogName;
            string strSQL = "";
            string connectionString = @"Data Source=LAPTOP-KD80G839\SQLEXPRESS;Initial Catalog=myhouse;Integrated Security=True"; //DB連線

            Guid newGuid = Guid.NewGuid();
            string guid = Guid.NewGuid().ToString();
            DateTime ReserveDate;
            string temp = dtp預約日期.Text;
            DateTime.TryParse(temp, out ReserveDate);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    foreach (DataGridViewRow row in dgv預約列表.Rows)
                    {
                        DataRowView dataRowView = (DataRowView)row.DataBoundItem;
                        DataRow newRow = Globalvar.Housetable.NewRow();
                        SqlCommand command = new SqlCommand(strSQL, connection); //下SQL去撈資料瞜
                        strSQL = @"insert into reserve(guid, 預約帳號, 預約姓名, 物件id, 物件名稱, 預約日期, 是否已帶看) 
                                   values (@guid, @預約帳號, @預約姓名, @物件id, @物件名稱, @預約日期, @是否已帶看)";
                        command = new SqlCommand(strSQL, connection);
                        command.Parameters.AddWithValue("@guid", guid);
                        command.Parameters.AddWithValue("@預約帳號", LoginAccount);
                        command.Parameters.AddWithValue("@預約姓名", LogName);
                        command.Parameters.AddWithValue("@物件id", dataRowView["id"]);
                        command.Parameters.AddWithValue("@物件名稱", dataRowView["物件名稱"]);
                        command.Parameters.AddWithValue("@預約日期", ReserveDate);
                        command.Parameters.AddWithValue("@是否已帶看", "N");
                        command.ExecuteNonQuery();
                    }
                    MessageBox.Show("預約成功,將有專員與您聯絡!!!");

                }
                catch (Exception ex) //如有錯誤就跑來這並輸出錯誤訊息(ex)
                {
                    MessageBox.Show("預約失敗:" + ex.Message.ToString());
                }
                finally
                {
                    Globalvar.Housetable.Clear();
                }
            }
        }
    }
}
