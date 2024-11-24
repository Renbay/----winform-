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
    public partial class 訪客介面 : Form
    {
        //場景
        private Button currentButton;
        private Random random;
        private int tempIndex;
        Form activeForm;


        public 訪客介面()
        {
            InitializeComponent();
            random = new Random();

        }
        //方法
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index) //已經選擇的顏色下次會選擇不同的顏色
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender) //啟動按鈕,隨機選色
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("微軟正黑體", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                    panelTitleBar.BackColor = color;
                    //值必須以小數為單位(0.1, 0.05, -0.1, 0.3)
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                }
            }
        }

        private void DisableButton() //停止按鈕時
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                }
            }
        }

        // 建立一個方法來開啟桌面中的表單
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl高雄房屋資訊系統.Text = childForm.Text;
        }


        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 訪客介面_Load(object sender, EventArgs e)
        {

        }

        private void btn房屋物件_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.訪客房屋物件(), sender);

        }

        private void btn加入會員_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.註冊畫面(), sender);

        }

        private void btn聯絡我們_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.聯絡我們(), sender);

        }
    }
}
