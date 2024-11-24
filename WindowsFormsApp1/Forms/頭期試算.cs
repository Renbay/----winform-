using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class 頭期試算 : Form
    {
        public 頭期試算()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn開始試算_Click(object sender, EventArgs e)
        {
            if ((txt預估購買價格.Text != "") && (txt自備款.Text != "") && (txt利率.Text != "") && (txt貸款年數.Text != "") && (txt擁有房屋數.Text != ""))
            {
                int 預估購買價格 = Convert.ToInt32(txt預估購買價格.Text);
                int 自備款 = Convert.ToInt32(txt自備款.Text);
                double 年利率 = Convert.ToDouble(txt利率.Text);
                int 貸款年數 = Convert.ToInt32(txt貸款年數.Text);
                int 擁有房屋數 = Convert.ToInt32(txt擁有房屋數.Text);

                double 月利率 = 年利率 / 12;
                double 金額 = 0;

                switch (擁有房屋數)
                {
                    case 1:
                        //{ [(1＋月利率)^月數]×月利率}÷{ [(1＋月利率)^月數]－1}
                        金額 = Math.Round((Math.Pow(1 + 月利率, 12) * 月利率) / (Math.Pow(1 + 月利率, 12) - 1), 0);
                        break;
                    default:
                        break;
                }


            }
            else
            {
                MessageBox.Show("請輸入完整資料!!");
            }
        }

        private void 頭期試算_Load(object sender, EventArgs e)
        {

        }
    }
}
