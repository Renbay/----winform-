namespace WindowsFormsApp1
{
    partial class 高雄房屋資訊系統
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn設定 = new System.Windows.Forms.Button();
            this.btn聯絡我們 = new System.Windows.Forms.Button();
            this.btn預約列表 = new System.Windows.Forms.Button();
            this.btn房屋物件 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogName = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbl高雄房屋資訊系統 = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn設定);
            this.panelMenu.Controls.Add(this.btn聯絡我們);
            this.panelMenu.Controls.Add(this.btn預約列表);
            this.panelMenu.Controls.Add(this.btn房屋物件);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(318, 962);
            this.panelMenu.TabIndex = 0;
            // 
            // btn設定
            // 
            this.btn設定.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn設定.FlatAppearance.BorderSize = 0;
            this.btn設定.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn設定.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn設定.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn設定.Image = global::WindowsFormsApp1.Properties.Resources.設定圖片1;
            this.btn設定.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn設定.Location = new System.Drawing.Point(0, 447);
            this.btn設定.Name = "btn設定";
            this.btn設定.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn設定.Size = new System.Drawing.Size(318, 111);
            this.btn設定.TabIndex = 6;
            this.btn設定.Text = "更改資料";
            this.btn設定.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn設定.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn設定.UseVisualStyleBackColor = true;
            this.btn設定.Click += new System.EventHandler(this.btn更改資料_Click);
            // 
            // btn聯絡我們
            // 
            this.btn聯絡我們.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn聯絡我們.FlatAppearance.BorderSize = 0;
            this.btn聯絡我們.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn聯絡我們.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn聯絡我們.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn聯絡我們.Image = global::WindowsFormsApp1.Properties.Resources.電話1;
            this.btn聯絡我們.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn聯絡我們.Location = new System.Drawing.Point(0, 329);
            this.btn聯絡我們.Name = "btn聯絡我們";
            this.btn聯絡我們.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn聯絡我們.Size = new System.Drawing.Size(318, 118);
            this.btn聯絡我們.TabIndex = 5;
            this.btn聯絡我們.Text = "聯絡我們";
            this.btn聯絡我們.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn聯絡我們.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn聯絡我們.UseVisualStyleBackColor = true;
            this.btn聯絡我們.Click += new System.EventHandler(this.btn聯絡我們_Click);
            // 
            // btn預約列表
            // 
            this.btn預約列表.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn預約列表.FlatAppearance.BorderSize = 0;
            this.btn預約列表.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn預約列表.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn預約列表.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn預約列表.Image = global::WindowsFormsApp1.Properties.Resources.列表;
            this.btn預約列表.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn預約列表.Location = new System.Drawing.Point(0, 213);
            this.btn預約列表.Name = "btn預約列表";
            this.btn預約列表.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn預約列表.Size = new System.Drawing.Size(318, 116);
            this.btn預約列表.TabIndex = 3;
            this.btn預約列表.Text = "預約列表";
            this.btn預約列表.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn預約列表.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn預約列表.UseVisualStyleBackColor = true;
            this.btn預約列表.Click += new System.EventHandler(this.btn預約列表_Click);
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
            this.btn房屋物件.Size = new System.Drawing.Size(318, 111);
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
            this.panelLogo.Controls.Add(this.lblLogName);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(318, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogName
            // 
            this.lblLogName.AutoSize = true;
            this.lblLogName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLogName.ForeColor = System.Drawing.Color.Snow;
            this.lblLogName.Location = new System.Drawing.Point(70, 39);
            this.lblLogName.Name = "lblLogName";
            this.lblLogName.Size = new System.Drawing.Size(86, 31);
            this.lblLogName.TabIndex = 0;
            this.lblLogName.Text = "您好！";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.panelTitleBar.Controls.Add(this.lbl高雄房屋資訊系統);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(318, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1208, 102);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lbl高雄房屋資訊系統
            // 
            this.lbl高雄房屋資訊系統.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl高雄房屋資訊系統.AutoSize = true;
            this.lbl高雄房屋資訊系統.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl高雄房屋資訊系統.ForeColor = System.Drawing.Color.White;
            this.lbl高雄房屋資訊系統.Location = new System.Drawing.Point(389, 24);
            this.lbl高雄房屋資訊系統.Name = "lbl高雄房屋資訊系統";
            this.lbl高雄房屋資訊系統.Size = new System.Drawing.Size(407, 46);
            this.lbl高雄房屋資訊系統.TabIndex = 0;
            this.lbl高雄房屋資訊系統.Text = "高雄123不動產資訊系統";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(318, 102);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(1208, 860);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // 高雄房屋資訊系統
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 962);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "高雄房屋資訊系統";
            this.Text = "高雄房屋資訊系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btn房屋物件;
        private System.Windows.Forms.Button btn設定;
        private System.Windows.Forms.Button btn聯絡我們;
        private System.Windows.Forms.Button btn預約列表;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lbl高雄房屋資訊系統;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Label lblLogName;
    }
}

