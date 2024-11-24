using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new 高雄房屋資訊系統());
            //Application.Run(new Form房屋物件());
            //Application.Run(new 管理者介面());
            //Application.Run(new 註冊畫面());
            Application.Run(new 登入畫面());
            //Application.Run(new 註冊畫面());
            //Application.Run(new 客戶預約列表());




        }
    }
}
