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
    public partial class manager_房屋物件 : Form
    {
        public manager_房屋物件()
        {
            InitializeComponent();
            InitializeCartTable();
        }

        private void InitializeCartTable()
        {
            if (Globalvar.Housetable.Columns.Count == 0)
            {
                Globalvar.Housetable.Columns.Add("id");
                Globalvar.Housetable.Columns.Add("物件名稱");
                Globalvar.Housetable.Columns.Add("屋齡");
                Globalvar.Housetable.Columns.Add("坪數");
                Globalvar.Housetable.Columns.Add("行政區域");
                Globalvar.Housetable.Columns.Add("物件型態");
                Globalvar.Housetable.Columns.Add("車位");
                Globalvar.Housetable.Columns.Add("房數");
                Globalvar.Housetable.Columns.Add("價格");
                Globalvar.Housetable.Columns.Add("社區名稱");
                // 添加其他你需要的列
            }
        }

        private void houseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.houseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myhouseDataSet);

        }


        private void manager_房屋物件_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-KD80G839\SQLEXPRESS;Initial Catalog=myhouse;Integrated Security=True";
            string query = "";
            houseDataGridView.DataSource = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    query = "SELECT * FROM house where 1=1 ";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        houseDataGridView.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            houseDataGridView.AllowUserToAddRows = false;

            cbox行政區域.Items.Add("請選擇");
            cbox行政區域.Items.Add("前金區");
            cbox行政區域.Items.Add("新興區");
            cbox行政區域.Items.Add("鹽埕區");
            cbox行政區域.Items.Add("左營區");
            cbox行政區域.Items.Add("楠梓區");
            cbox行政區域.Items.Add("鼓山區");
            cbox行政區域.Items.Add("旗津區");
            cbox行政區域.Items.Add("苓雅區");
            cbox行政區域.Items.Add("三民區");
            cbox行政區域.Items.Add("前鎮區");
            cbox行政區域.Items.Add("小港區");
            cbox行政區域.Items.Add("鳳山區");
            cbox行政區域.Items.Add("鳥松區");
            cbox行政區域.Items.Add("大社區");
            cbox行政區域.Items.Add("仁武區");
            cbox行政區域.Items.Add("大樹區");
            cbox行政區域.Items.Add("岡山區");
            cbox行政區域.Items.Add("燕巢區");
            cbox行政區域.Items.Add("梓官區");
            cbox行政區域.Items.Add("永安區");
            cbox行政區域.Items.Add("彌陀區");
            cbox行政區域.Items.Add("橋頭區");
            cbox行政區域.Items.Add("田寮區");
            cbox行政區域.Items.Add("茄萣區");
            cbox行政區域.Items.Add("阿蓮區");
            cbox行政區域.Items.Add("路竹區");
            cbox行政區域.Items.Add("湖內區");
            cbox行政區域.Items.Add("那瑪夏區");
            cbox行政區域.Items.Add("桃源區");
            cbox行政區域.Items.Add("茂林區");
            cbox行政區域.Items.Add("六龜區");
            cbox行政區域.Items.Add("美濃區");
            cbox行政區域.Items.Add("旗山區");
            cbox行政區域.Items.Add("甲仙區");
            cbox行政區域.Items.Add("內門區");
            cbox行政區域.Items.Add("杉林區");
            cbox行政區域.Items.Add("林園區");
            cbox行政區域.Items.Add("大寮區");
            cbox行政區域.SelectedIndex = 0;

            cbox物件型態.Items.Add("請選擇");
            cbox物件型態.Items.Add("無電梯公寓");
            cbox物件型態.Items.Add("透天");
            cbox物件型態.Items.Add("大樓");
            cbox物件型態.Items.Add("套房");
            cbox物件型態.SelectedIndex = 0;

            cbox車位.Items.Add("請選擇");
            cbox車位.Items.Add("無車位");
            cbox車位.Items.Add("平面車位");
            cbox車位.Items.Add("機械車位");
            cbox車位.SelectedIndex = 0;

            cbox房數.Items.Add("請選擇");
            cbox房數.Items.Add("一房");
            cbox房數.Items.Add("兩房");
            cbox房數.Items.Add("三房");
            cbox房數.Items.Add("四房");
            cbox房數.Items.Add("四房以上");
            cbox房數.SelectedIndex = 0;

            顯示資料筆數();
        }

        void 顯示資料筆數()
        {
            int 總筆數 = houseDataGridView.RowCount;
            //int 目前第幾筆 = houseBindingSource.Position + 1;

            lbl總筆數.Text = $"總筆數: 共{總筆數}筆";
        }

        private void btn查詢_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-KD80G839\SQLEXPRESS;Initial Catalog=myhouse;Integrated Security=True";
            string query = "";
            houseDataGridView.DataSource = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    query = "SELECT * FROM house where 1=1 ";

                    if (cbox行政區域.Text != "請選擇") //行政區域
                    {
                        string str行政區域 = cbox行政區域.Text;

                        query += $" and 行政區域 = '{str行政區域}'";
                    }

                    if (txt屋齡年1.Text != "")
                    {
                        int 屋齡年1 = Convert.ToInt32(txt屋齡年1.Text); //屋齡

                        query += $" and 屋齡 >= '{屋齡年1.ToString()}'";

                        if (txt屋齡年2.Text != "")
                        {
                            int 屋齡年2 = Convert.ToInt32(txt屋齡年2.Text);

                            query += $" and 屋齡 >= {屋齡年1.ToString()} and 屋齡 <= {屋齡年2.ToString()}";
                        }
                    }
                    else
                    {
                        if (txt屋齡年2.Text != "")
                        {
                            int 屋齡年2 = Convert.ToInt32(txt屋齡年2.Text);

                            query += $" and 屋齡 <= '{屋齡年2.ToString()}'";
                        }
                    }

                    if (cbox房數.Text != "請選擇") //房間數
                    {
                        string str房數 = cbox房數.Text;

                        query += $" and 房數 = '{str房數}'";

                        if  (cbox房數.Text == "四房以上")
                        {
                            query = $"select * from house where 房數 not in ('一房','兩房','三房','四房', ' ')";
                        }
                    }

                    if (cbox物件型態.Text != "請選擇") //物件型態
                    {
                        string str物件型態 = cbox物件型態.Text;

                        query += $" and 物件型態 = '{str物件型態}'";
                    }

                    if (cbox車位.Text != "請選擇") //車位
                    {
                        string str車位 = cbox車位.Text;

                        query += $" and 車位 = '{str車位}'";
                    }

                    if (txt價格萬1.Text != "") //價格
                    {
                        int 價格萬1 = Convert.ToInt32(txt價格萬1.Text);

                        query += $" and 價格 >= '{價格萬1.ToString()}'";

                        if (txt價格萬2.Text != "")
                        {
                            int 價格萬2 = Convert.ToInt32(txt價格萬2.Text);

                            query += $" and 價格 >= {價格萬1.ToString()} and 價格 <= {價格萬2.ToString()}";
                        }
                    }

                    if (txt價格萬2.Text != "")
                    {
                        int 價格萬2 = Convert.ToInt32(txt價格萬2.Text);

                        query += $" and 價格 <= '{價格萬2.ToString()}'";
                    }

                    

                    SqlCommand command = new SqlCommand(query, connection);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        houseDataGridView.DataSource = dataTable;
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            顯示資料筆數();
        }
        

        private void btn清除資料_Click(object sender, EventArgs e)
        {
            cbox行政區域.SelectedIndex = 0;
            cbox物件型態.SelectedIndex = 0;
            cbox車位.SelectedIndex = 0;
            cbox房數.SelectedIndex = 0;
            txt屋齡年1.Clear();
            txt屋齡年2.Clear();
            txt價格萬1.Clear();
            txt價格萬2.Clear();
        }
    }
}
