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
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1.Forms
{
    public partial class 物件管理 : Form
    {
        SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
        string strDBConnectionString = "";
        List<int>Searchs = new List<int>();
        int DGV筆數 = 0;




        public 物件管理()
        {
            InitializeComponent();
        }

        private void 物件管理_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'myhouseDataSet2.house' 資料表。您可以視需要進行移動或移除。
            this.houseTableAdapter.Fill(this.myhouseDataSet2.house);
            scsb.DataSource = @"LAPTOP-KD80G839\SQLEXPRESS";
            scsb.InitialCatalog = "myhouse";
            scsb.IntegratedSecurity = true;

            strDBConnectionString = scsb.ConnectionString.ToString();

        }

        private void btn資料搜尋_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBConnectionString);
            con.Open();
            string strSQL = "select * from house where 物件名稱 like @SearchName;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchName", $"%{txt物件名稱.Text}%");
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read() == true)
            {
                txtid.Text = reader["id"].ToString();
                txt物件名稱.Text = (string)reader["物件名稱"];
                txt行政區域.Text = (string)reader["行政區域"];
                txt物件型態.Text = (string)reader["物件型態"];
                txt車位.Text = (string)reader["車位"];
                txt房數.Text = (string)reader["房數"];
                txt屋齡.Text = reader["屋齡"].ToString();
                txt價格.Text = reader["價格"].ToString();
                txt坪數.Text = reader["坪數"].ToString();
                txt社區名稱.Text = (string)reader["社區名稱"];
            }
            else
            {
                MessageBox.Show("無此物件");
            }

            reader.Close();
            con.Close();
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txtid.Text, out intId);

            if ((intId > 0) && (txt物件名稱.Text != "") && (txt行政區域.Text != "") && (txt物件型態.Text != "") && (txt車位.Text != "") && (txt房數.Text != "") && (txt屋齡.Text != "") && (txt價格.Text != "") && (txt坪數.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "update house set 物件名稱=@NewName, 行政區域=@NewArea, 物件型態=@NewType, 車位=@NewPark, 房數=@NewRoom, 屋齡=@NewAge, 價格=@NewProduct, 坪數=@NewPy where id=@SearchId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", intId);
                cmd.Parameters.AddWithValue("@NewName", txt物件名稱.Text);
                cmd.Parameters.AddWithValue("@NewArea", txt行政區域.Text);
                cmd.Parameters.AddWithValue("@NewType", txt物件型態.Text);
                cmd.Parameters.AddWithValue("@NewPark", txt車位.Text);
                cmd.Parameters.AddWithValue("@NewRoom", txt房數.Text);

                int intAge = 0;
                Int32.TryParse(txt屋齡.Text, out intAge);
                cmd.Parameters.AddWithValue("@NewAge", intAge);

                int intProduct = 0;
                Int32.TryParse(txt價格.Text, out intProduct);
                cmd.Parameters.AddWithValue("@NewProduct", intProduct);

                double doublePy = 0;
                double.TryParse(txt坪數.Text, out doublePy);
                cmd.Parameters.AddWithValue("@NewPy", doublePy);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料修改成功, {rows}列資料受到影響");
            }
            else
            {
                MessageBox.Show("欄位資料不全");
            }
        }

        private void btn資料新增_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txt物件名稱.Text != "") && (txt行政區域.Text != "") && (txt物件型態.Text != "") && (txt車位.Text != "") && (txt房數.Text != "") && (txt屋齡.Text != "") && (txt價格.Text != "") && (txt坪數.Text != ""))
                {
                    SqlConnection con = new SqlConnection(strDBConnectionString);
                    con.Open();
                    string strSQL = "insert into house (物件名稱, 行政區域, 物件型態, 車位, 房數, 屋齡, 價格, 坪數, 社區名稱)" +
                        "values(@NewName, @NewArea, @NewType, @NewPark, @NewRoom, @NewAge, @NewProduct, @NewPy, @Name)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@NewName", txt物件名稱.Text);
                    cmd.Parameters.AddWithValue("@NewArea", txt行政區域.Text);
                    cmd.Parameters.AddWithValue("@NewType", txt物件型態.Text);
                    cmd.Parameters.AddWithValue("@NewPark", txt車位.Text);
                    cmd.Parameters.AddWithValue("@NewRoom", txt房數.Text);
                    cmd.Parameters.AddWithValue("@Name", txt社區名稱.Text);

                    int intAge = 0;
                    Int32.TryParse(txt屋齡.Text, out intAge);
                    cmd.Parameters.AddWithValue("@NewAge", intAge);

                    int intProduct = 0;
                    Int32.TryParse(txt價格.Text, out intProduct);
                    cmd.Parameters.AddWithValue("@NewProduct", intProduct);

                    double doublePy = 0.0;
                    double.TryParse(txt坪數.Text, out doublePy);
                    cmd.Parameters.AddWithValue("@NewPy", doublePy);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show($"資料修改成功, {rows}列資料受到影響");
                }
                else
                {
                    MessageBox.Show("欄位資料不全");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("房屋新增錯誤:" + ex.Message);
            }
        }
        private void btn資料刪除_Click(object sender, EventArgs e)
        {
            int intId = 0;
            Int32.TryParse(txtid.Text, out intId);

            if (intId > 0)
            {
                SqlConnection con = new SqlConnection(strDBConnectionString);
                con.Open();
                string strSQL = "delete from house where id = @DeleteId";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@DeleteId", intId);

                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"資料已刪除\n {rows} 列資料受影響");
                清空欄位();
            }

        }

        void 清空欄位()
        { 
            txtid.Clear();
            txt物件名稱.Clear();
            txt行政區域.Clear();
            txt物件型態.Clear();
            txt車位.Clear();
            txt房數.Clear();
            txt屋齡.Clear();
            txt價格.Clear();
            txt坪數.Clear();
            txt社區名稱.Clear();     
        }


        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();

        }

        private void btn顯示全部資料_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strDBConnectionString);
            conn.Open();
            string strSQL = "select top 200 * from house";
            SqlCommand cmd = new SqlCommand( strSQL, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == true)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DGV筆數 = dt.Rows.Count;
                Console.WriteLine($"DGV筆數: {DGV筆數}");
                
                dgv房屋資料列表.DataSource = dt;

            }

            reader.Close();
            conn.Close();
        }
    }
}
