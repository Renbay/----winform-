namespace WindowsFormsApp1.Forms
{
    partial class 登入畫面
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.btn登入 = new System.Windows.Forms.Button();
            this.btn註冊 = new System.Windows.Forms.Button();
            this.btn訪客登入 = new System.Windows.Forms.Button();
            this.btn忘記密碼 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTogglePasswordVisibility = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(61, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "帳號";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(61, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼";
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(162, 310);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(271, 39);
            this.txt帳號.TabIndex = 3;
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(162, 379);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(271, 39);
            this.txt密碼.TabIndex = 4;
            // 
            // btn登入
            // 
            this.btn登入.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(91, 469);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(157, 58);
            this.btn登入.TabIndex = 5;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = true;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // btn註冊
            // 
            this.btn註冊.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊.Location = new System.Drawing.Point(254, 469);
            this.btn註冊.Name = "btn註冊";
            this.btn註冊.Size = new System.Drawing.Size(157, 58);
            this.btn註冊.TabIndex = 6;
            this.btn註冊.Text = "註冊";
            this.btn註冊.UseVisualStyleBackColor = true;
            this.btn註冊.Click += new System.EventHandler(this.btn註冊_Click);
            // 
            // btn訪客登入
            // 
            this.btn訪客登入.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訪客登入.Location = new System.Drawing.Point(343, 719);
            this.btn訪客登入.Name = "btn訪客登入";
            this.btn訪客登入.Size = new System.Drawing.Size(173, 58);
            this.btn訪客登入.TabIndex = 7;
            this.btn訪客登入.Text = "訪客登入";
            this.btn訪客登入.UseVisualStyleBackColor = true;
            this.btn訪客登入.Click += new System.EventHandler(this.btn訪客登入_Click);
            // 
            // btn忘記密碼
            // 
            this.btn忘記密碼.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn忘記密碼.Location = new System.Drawing.Point(162, 719);
            this.btn忘記密碼.Name = "btn忘記密碼";
            this.btn忘記密碼.Size = new System.Drawing.Size(173, 58);
            this.btn忘記密碼.TabIndex = 8;
            this.btn忘記密碼.Text = "忘記密碼";
            this.btn忘記密碼.UseVisualStyleBackColor = true;
            this.btn忘記密碼.Click += new System.EventHandler(this.btn忘記密碼_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Lovepik_com_380269373_customer_login_avatar_client_gray_head_portrait;
            this.pictureBox1.Location = new System.Drawing.Point(119, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnTogglePasswordVisibility
            // 
            this.btnTogglePasswordVisibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTogglePasswordVisibility.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTogglePasswordVisibility.Location = new System.Drawing.Point(439, 375);
            this.btnTogglePasswordVisibility.Name = "btnTogglePasswordVisibility";
            this.btnTogglePasswordVisibility.Size = new System.Drawing.Size(45, 48);
            this.btnTogglePasswordVisibility.TabIndex = 9;
            this.btnTogglePasswordVisibility.Text = "😳";
            this.btnTogglePasswordVisibility.UseVisualStyleBackColor = false;
            this.btnTogglePasswordVisibility.Click += new System.EventHandler(this.btnTogglePasswordVisibility_Click);
            // 
            // 登入畫面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(528, 789);
            this.Controls.Add(this.btnTogglePasswordVisibility);
            this.Controls.Add(this.btn忘記密碼);
            this.Controls.Add(this.btn訪客登入);
            this.Controls.Add(this.btn註冊);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.txt密碼);
            this.Controls.Add(this.txt帳號);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "登入畫面";
            this.Text = "登入畫面";
            this.Load += new System.EventHandler(this.登入畫面_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Button btn登入;
        private System.Windows.Forms.Button btn註冊;
        private System.Windows.Forms.Button btn訪客登入;
        private System.Windows.Forms.Button btn忘記密碼;
        private System.Windows.Forms.Button btnTogglePasswordVisibility;
    }
}