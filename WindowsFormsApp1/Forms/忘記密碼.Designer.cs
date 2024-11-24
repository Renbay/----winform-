namespace WindowsFormsApp1.Forms
{
    partial class 忘記密碼
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
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbox回應訊息 = new System.Windows.Forms.ListBox();
            this.btn查詢 = new System.Windows.Forms.Button();
            this.btn返回登入畫面 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(163, 154);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(304, 39);
            this.txt帳號.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(76, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "帳號";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(76, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(76, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "電話";
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(163, 333);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(304, 39);
            this.txt電話.TabIndex = 10;
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(163, 245);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(304, 39);
            this.txt姓名.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(123, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "請輸入以下個人資訊";
            // 
            // lbox回應訊息
            // 
            this.lbox回應訊息.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox回應訊息.FormattingEnabled = true;
            this.lbox回應訊息.ItemHeight = 36;
            this.lbox回應訊息.Location = new System.Drawing.Point(12, 414);
            this.lbox回應訊息.Name = "lbox回應訊息";
            this.lbox回應訊息.Size = new System.Drawing.Size(547, 220);
            this.lbox回應訊息.TabIndex = 13;
            // 
            // btn查詢
            // 
            this.btn查詢.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查詢.Location = new System.Drawing.Point(58, 679);
            this.btn查詢.Name = "btn查詢";
            this.btn查詢.Size = new System.Drawing.Size(157, 58);
            this.btn查詢.TabIndex = 14;
            this.btn查詢.Text = "查詢";
            this.btn查詢.UseVisualStyleBackColor = true;
            this.btn查詢.Click += new System.EventHandler(this.btn查詢_Click);
            // 
            // btn返回登入畫面
            // 
            this.btn返回登入畫面.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn返回登入畫面.Location = new System.Drawing.Point(272, 679);
            this.btn返回登入畫面.Name = "btn返回登入畫面";
            this.btn返回登入畫面.Size = new System.Drawing.Size(235, 58);
            this.btn返回登入畫面.TabIndex = 15;
            this.btn返回登入畫面.Text = "返回登入畫面";
            this.btn返回登入畫面.UseVisualStyleBackColor = true;
            this.btn返回登入畫面.Click += new System.EventHandler(this.btn返回登入畫面_Click);
            // 
            // 忘記密碼
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(571, 789);
            this.Controls.Add(this.btn返回登入畫面);
            this.Controls.Add(this.btn查詢);
            this.Controls.Add(this.lbox回應訊息);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt姓名);
            this.Controls.Add(this.txt電話);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.label3);
            this.Name = "忘記密碼";
            this.Text = "忘記密碼";
            this.Load += new System.EventHandler(this.忘記密碼_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbox回應訊息;
        private System.Windows.Forms.Button btn查詢;
        private System.Windows.Forms.Button btn返回登入畫面;
    }
}