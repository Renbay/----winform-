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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1.Forms
{
    public partial class 客戶預約列表 : Form
    {
        public 客戶預約列表()
        {
            InitializeComponent();
        }

        private void 客戶預約列表_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable(); //把TABLE資料讀進來這
            string LoginAccount = Globalvar.LoginAccount;
            string LogName = Globalvar.LogName;
            string strSQL = "";
            string connectionString = @"Data Source=LAPTOP-KD80G839\SQLEXPRESS;Initial Catalog=myhouse;Integrated Security=True"; //DB連線

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    strSQL = @"select 預約姓名, 物件名稱, 預約日期, 是否已帶看 from reserve";
                    SqlCommand command = new SqlCommand(strSQL, connection); //下SQL去撈資料瞜
                    using (SqlDataReader reader = command.ExecuteReader()) //把資料read到table
                    {
                        dataTable.Load(reader);
                    }

                    dgv客戶預約列表.DataSource = dataTable;
                }
                catch (Exception ex) //如有錯誤就跑來這並輸出錯誤訊息(ex)
                {
                    MessageBox.Show("查詢失敗:" + ex.Message.ToString());
                }
                finally
                {
                    connection.Dispose();
                }
            }

        }

        private void btn資料輸出_Click(object sender, EventArgs e)
        {
            #region
            //string str預設檔案輸出目錄 = @"C:\Users\User\Desktop\個人專題-20240722T145554Z-001\客戶預約表單";

            //Random myRnd = new Random();
            //int numRnd = myRnd.Next(1000, 10000);
            //string str檔名 = DateTime.Now.ToString("yyMMddHHmmSS") + numRnd + "預約表單.txt";
            //string str完整路徑檔名 = str預設檔案輸出目錄 + @"\" + str檔名;

            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "文字檔 (*.txt)|*.txt";
            //saveFileDialog.Title = "Save DataGridView as Text File";
            //saveFileDialog.FileName = str檔名;

            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        // 建立 StreamWriter 並寫入檔案
            //        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
            //        {
            //            // 寫入標題行 (可選)
            //            for (int i = 0; i < dgv客戶預約列表.Columns.Count; i++)
            //            {
            //                sw.Write(dgv客戶預約列表.Columns[i].HeaderText);
            //                if (i < dgv客戶預約列表.Columns.Count - 1)
            //                {
            //                    sw.Write("\t"); // 使用 tab 分隔欄位
            //                    sw.Write("\t"); // 使用 tab 分隔欄位
            //                    sw.Write("\t"); // 使用 tab 分隔欄位
            //                }
            //            }
            //            sw.WriteLine();

            //            // 寫入資料行
            //            foreach (DataGridViewRow row in dgv客戶預約列表.Rows)
            //            {
            //                for (int i = 0; i < dgv客戶預約列表.Columns.Count; i++)
            //                {
            //                    sw.Write(row.Cells[i].Value?.ToString());
            //                    if (i < dgv客戶預約列表.Columns.Count - 1)
            //                    {
            //                        sw.Write("\t"); // 使用 tab 分隔欄位
            //                        sw.Write("\t"); // 使用 tab 分隔欄位
            //                        sw.Write("\t"); // 使用 tab 分隔欄位
            //                    }
            //                }
            //                sw.WriteLine();
            //            }
            //        }

            //        MessageBox.Show("資料成功匯出至TXT檔案！", "匯出完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"匯出失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            #endregion

            // 創建Excel應用程序對象
            Excel.Application excelApp = new Excel.Application();

            if (excelApp == null)
            {
                MessageBox.Show("Excel 沒有安裝");
                return;
            }

            // 創建一個新的工作簿
            Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);

            // 創建一個工作表
            Excel.Worksheet worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "DataGridView Data";

            // 將DataGridView的列名導出到Excel
            for (int i = 1; i < dgv客戶預約列表.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgv客戶預約列表.Columns[i - 1].HeaderText;
            }

            // 將DataGridView的數據導出到Excel
            for (int i = 0; i < dgv客戶預約列表.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgv客戶預約列表.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgv客戶預約列表.Rows[i].Cells[j].Value.ToString();
                }
            }

            // 保存Excel文件
            var saveFileDialog = new SaveFileDialog
            {
                FileName = "output",
                DefaultExt = ".xlsx",
                Filter = "Excel files (*.xlsx)|*.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("文件已成功導出");
            }

            // 釋放Excel對象
            workbook.Close();
            excelApp.Quit();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            if (dgv客戶預約列表.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv客戶預約列表.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgv客戶預約列表.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("請選擇要刪除預約的資料");
            }
        }
    }
}
