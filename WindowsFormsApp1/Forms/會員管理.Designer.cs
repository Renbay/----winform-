namespace WindowsFormsApp1.Forms
{
    partial class 會員管理
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn資料新增 = new System.Windows.Forms.Button();
            this.btn資料刪除 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt住址 = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.txt電話 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt信箱 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt姓名 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv會員資料列表 = new System.Windows.Forms.DataGridView();
            this.btn顯示全部資料 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp生日 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料列表)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btn清空欄位);
            this.groupBox1.Controls.Add(this.btn資料新增);
            this.groupBox1.Controls.Add(this.btn資料刪除);
            this.groupBox1.Controls.Add(this.btn資料修改);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 773);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能按鈕";
            // 
            // btn清空欄位
            // 
            this.btn清空欄位.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空欄位.Location = new System.Drawing.Point(23, 568);
            this.btn清空欄位.Name = "btn清空欄位";
            this.btn清空欄位.Size = new System.Drawing.Size(198, 71);
            this.btn清空欄位.TabIndex = 4;
            this.btn清空欄位.Text = "清空欄位";
            this.btn清空欄位.UseVisualStyleBackColor = true;
            this.btn清空欄位.Click += new System.EventHandler(this.btn清空欄位_Click);
            // 
            // btn資料新增
            // 
            this.btn資料新增.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料新增.Location = new System.Drawing.Point(23, 317);
            this.btn資料新增.Name = "btn資料新增";
            this.btn資料新增.Size = new System.Drawing.Size(198, 74);
            this.btn資料新增.TabIndex = 3;
            this.btn資料新增.Text = "資料新增";
            this.btn資料新增.UseVisualStyleBackColor = true;
            this.btn資料新增.Click += new System.EventHandler(this.btn資料新增_Click);
            // 
            // btn資料刪除
            // 
            this.btn資料刪除.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料刪除.Location = new System.Drawing.Point(23, 448);
            this.btn資料刪除.Name = "btn資料刪除";
            this.btn資料刪除.Size = new System.Drawing.Size(198, 72);
            this.btn資料刪除.TabIndex = 2;
            this.btn資料刪除.Text = "資料刪除";
            this.btn資料刪除.UseVisualStyleBackColor = true;
            this.btn資料刪除.Click += new System.EventHandler(this.btn資料刪除_Click);
            // 
            // btn資料修改
            // 
            this.btn資料修改.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料修改.Location = new System.Drawing.Point(23, 202);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(198, 73);
            this.btn資料修改.TabIndex = 1;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.UseVisualStyleBackColor = true;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // btn資料搜尋
            // 
            this.btn資料搜尋.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料搜尋.Location = new System.Drawing.Point(23, 90);
            this.btn資料搜尋.Name = "btn資料搜尋";
            this.btn資料搜尋.Size = new System.Drawing.Size(198, 66);
            this.btn資料搜尋.TabIndex = 0;
            this.btn資料搜尋.Text = "資料搜尋";
            this.btn資料搜尋.UseVisualStyleBackColor = true;
            this.btn資料搜尋.Click += new System.EventHandler(this.btn資料搜尋_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.dtp生日);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt住址);
            this.groupBox2.Controls.Add(this.txt密碼);
            this.groupBox2.Controls.Add(this.txt電話);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt信箱);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt姓名);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt帳號);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(273, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 773);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "資料欄位";
            // 
            // txt住址
            // 
            this.txt住址.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt住址.Location = new System.Drawing.Point(107, 582);
            this.txt住址.Name = "txt住址";
            this.txt住址.Size = new System.Drawing.Size(318, 42);
            this.txt住址.TabIndex = 11;
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(107, 475);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.Size = new System.Drawing.Size(258, 42);
            this.txt密碼.TabIndex = 10;
            // 
            // txt電話
            // 
            this.txt電話.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt電話.Location = new System.Drawing.Point(107, 379);
            this.txt電話.Name = "txt電話";
            this.txt電話.Size = new System.Drawing.Size(258, 42);
            this.txt電話.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(20, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "住址";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(20, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "密碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(20, 384);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "電話";
            // 
            // txt信箱
            // 
            this.txt信箱.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt信箱.Location = new System.Drawing.Point(107, 277);
            this.txt信箱.Name = "txt信箱";
            this.txt信箱.Size = new System.Drawing.Size(318, 42);
            this.txt信箱.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(20, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "信箱";
            // 
            // txt姓名
            // 
            this.txt姓名.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt姓名.Location = new System.Drawing.Point(107, 182);
            this.txt姓名.Name = "txt姓名";
            this.txt姓名.Size = new System.Drawing.Size(205, 42);
            this.txt姓名.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(20, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名";
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(107, 90);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(258, 42);
            this.txt帳號.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號";
            // 
            // dgv會員資料列表
            // 
            this.dgv會員資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv會員資料列表.Location = new System.Drawing.Point(21, 54);
            this.dgv會員資料列表.Name = "dgv會員資料列表";
            this.dgv會員資料列表.RowHeadersWidth = 62;
            this.dgv會員資料列表.RowTemplate.Height = 31;
            this.dgv會員資料列表.Size = new System.Drawing.Size(437, 615);
            this.dgv會員資料列表.TabIndex = 2;
            this.dgv會員資料列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv會員資料列表_CellClick);
            // 
            // btn顯示全部資料
            // 
            this.btn顯示全部資料.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn顯示全部資料.Location = new System.Drawing.Point(115, 675);
            this.btn顯示全部資料.Name = "btn顯示全部資料";
            this.btn顯示全部資料.Size = new System.Drawing.Size(266, 75);
            this.btn顯示全部資料.TabIndex = 4;
            this.btn顯示全部資料.Text = "顯示全部資料";
            this.btn顯示全部資料.UseVisualStyleBackColor = true;
            this.btn顯示全部資料.Click += new System.EventHandler(this.btn顯示全部資料_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(202)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.btn顯示全部資料);
            this.groupBox3.Controls.Add(this.dgv會員資料列表);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(721, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 773);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "會員資料列表";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 666);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "生日";
            // 
            // dtp生日
            // 
            this.dtp生日.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp生日.Location = new System.Drawing.Point(107, 666);
            this.dtp生日.Name = "dtp生日";
            this.dtp生日.Size = new System.Drawing.Size(299, 45);
            this.dtp生日.TabIndex = 13;
            // 
            // 會員管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1225, 806);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "會員管理";
            this.Text = "會員管理";
            this.Load += new System.EventHandler(this.會員管理_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料列表)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn資料新增;
        private System.Windows.Forms.Button btn資料刪除;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt信箱;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt姓名;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt住址;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.TextBox txt電話;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv會員資料列表;
        private System.Windows.Forms.Button btn顯示全部資料;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp生日;
        private System.Windows.Forms.Label label7;
    }
}