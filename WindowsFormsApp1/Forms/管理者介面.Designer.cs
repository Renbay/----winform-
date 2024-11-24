namespace WindowsFormsApp1.Forms
{
    partial class 管理者介面
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn物件管理 = new System.Windows.Forms.Button();
            this.btn會員管理 = new System.Windows.Forms.Button();
            this.btn客戶預約列表 = new System.Windows.Forms.Button();
            this.btn房屋物件 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbl高雄房屋資訊系統 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(320, 102);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1238, 824);
            this.panelDesktopPanel.TabIndex = 8;
            this.panelDesktopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPanel_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn物件管理);
            this.panelMenu.Controls.Add(this.btn會員管理);
            this.panelMenu.Controls.Add(this.btn客戶預約列表);
            this.panelMenu.Controls.Add(this.btn房屋物件);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 102);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(320, 824);
            this.panelMenu.TabIndex = 6;
            // 
            // btn物件管理
            // 
            this.btn物件管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn物件管理.FlatAppearance.BorderSize = 0;
            this.btn物件管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn物件管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn物件管理.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn物件管理.Image = global::WindowsFormsApp1.Properties.Resources.設定圖片1;
            this.btn物件管理.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn物件管理.Location = new System.Drawing.Point(0, 444);
            this.btn物件管理.Name = "btn物件管理";
            this.btn物件管理.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn物件管理.Size = new System.Drawing.Size(320, 111);
            this.btn物件管理.TabIndex = 6;
            this.btn物件管理.Text = "物件管理";
            this.btn物件管理.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn物件管理.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn物件管理.UseVisualStyleBackColor = true;
            this.btn物件管理.Click += new System.EventHandler(this.btn物件管理_Click);
            // 
            // btn會員管理
            // 
            this.btn會員管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn會員管理.FlatAppearance.BorderSize = 0;
            this.btn會員管理.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn會員管理.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員管理.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn會員管理.Image = global::WindowsFormsApp1.Properties.Resources._112;
            this.btn會員管理.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn會員管理.Location = new System.Drawing.Point(0, 329);
            this.btn會員管理.Name = "btn會員管理";
            this.btn會員管理.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn會員管理.Size = new System.Drawing.Size(320, 115);
            this.btn會員管理.TabIndex = 4;
            this.btn會員管理.Text = "會員管理";
            this.btn會員管理.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn會員管理.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn會員管理.UseVisualStyleBackColor = true;
            this.btn會員管理.Click += new System.EventHandler(this.btn會員管理_Click);
            // 
            // btn客戶預約列表
            // 
            this.btn客戶預約列表.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn客戶預約列表.FlatAppearance.BorderSize = 0;
            this.btn客戶預約列表.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn客戶預約列表.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn客戶預約列表.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn客戶預約列表.Image = global::WindowsFormsApp1.Properties.Resources.列表;
            this.btn客戶預約列表.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn客戶預約列表.Location = new System.Drawing.Point(0, 213);
            this.btn客戶預約列表.Name = "btn客戶預約列表";
            this.btn客戶預約列表.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn客戶預約列表.Size = new System.Drawing.Size(320, 116);
            this.btn客戶預約列表.TabIndex = 3;
            this.btn客戶預約列表.Text = "客戶預約列表";
            this.btn客戶預約列表.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn客戶預約列表.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn客戶預約列表.UseVisualStyleBackColor = true;
            this.btn客戶預約列表.Click += new System.EventHandler(this.btn客戶預約列表_Click);
            // 
            // btn房屋物件
            // 
            this.btn房屋物件.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn房屋物件.FlatAppearance.BorderSize = 0;
            this.btn房屋物件.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn房屋物件.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn房屋物件.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn房屋物件.Image = global::WindowsFormsApp1.Properties.Resources.房子21;
            this.btn房屋物件.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn房屋物件.Location = new System.Drawing.Point(0, 102);
            this.btn房屋物件.Name = "btn房屋物件";
            this.btn房屋物件.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn房屋物件.Size = new System.Drawing.Size(320, 111);
            this.btn房屋物件.TabIndex = 1;
            this.btn房屋物件.Text = "房屋物件";
            this.btn房屋物件.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn房屋物件.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn房屋物件.UseVisualStyleBackColor = true;
            this.btn房屋物件.Click += new System.EventHandler(this.btn房屋物件_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(320, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "經理您好";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.panelTitleBar.Controls.Add(this.lbl高雄房屋資訊系統);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1558, 102);
            this.panelTitleBar.TabIndex = 7;
            // 
            // lbl高雄房屋資訊系統
            // 
            this.lbl高雄房屋資訊系統.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl高雄房屋資訊系統.AutoSize = true;
            this.lbl高雄房屋資訊系統.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl高雄房屋資訊系統.ForeColor = System.Drawing.Color.White;
            this.lbl高雄房屋資訊系統.Location = new System.Drawing.Point(647, 26);
            this.lbl高雄房屋資訊系統.Name = "lbl高雄房屋資訊系統";
            this.lbl高雄房屋資訊系統.Size = new System.Drawing.Size(407, 46);
            this.lbl高雄房屋資訊系統.TabIndex = 0;
            this.lbl高雄房屋資訊系統.Text = "高雄123不動產資訊系統";
            // 
            // 管理者介面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1558, 926);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTitleBar);
            this.Name = "管理者介面";
            this.Text = "管理者介面";
            this.Load += new System.EventHandler(this.管理者介面_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn物件管理;
        private System.Windows.Forms.Button btn會員管理;
        private System.Windows.Forms.Button btn客戶預約列表;
        private System.Windows.Forms.Button btn房屋物件;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl高雄房屋資訊系統;
    }
}