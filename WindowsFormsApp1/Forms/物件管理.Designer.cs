namespace WindowsFormsApp1.Forms
{
    partial class 物件管理
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn顯示全部資料 = new System.Windows.Forms.Button();
            this.dgv房屋資料列表 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt房數 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt價格 = new System.Windows.Forms.TextBox();
            this.txt坪數 = new System.Windows.Forms.TextBox();
            this.txt社區名稱 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt屋齡 = new System.Windows.Forms.TextBox();
            this.txt車位 = new System.Windows.Forms.TextBox();
            this.txt物件型態 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt行政區域 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt物件名稱 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn清空欄位 = new System.Windows.Forms.Button();
            this.btn資料新增 = new System.Windows.Forms.Button();
            this.btn資料刪除 = new System.Windows.Forms.Button();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.btn資料搜尋 = new System.Windows.Forms.Button();
            this.myhouseDataSet2 = new WindowsFormsApp1.myhouseDataSet2();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.houseTableAdapter = new WindowsFormsApp1.myhouseDataSet2TableAdapters.houseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.物件名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.價格DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.社區名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv房屋資料列表)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.groupBox3.Controls.Add(this.btn顯示全部資料);
            this.groupBox3.Controls.Add(this.dgv房屋資料列表);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(721, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 773);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "房屋資料列表";
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
            // dgv房屋資料列表
            // 
            this.dgv房屋資料列表.AutoGenerateColumns = false;
            this.dgv房屋資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv房屋資料列表.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.物件名稱DataGridViewTextBoxColumn,
            this.價格DataGridViewTextBoxColumn,
            this.社區名稱DataGridViewTextBoxColumn});
            this.dgv房屋資料列表.DataSource = this.houseBindingSource;
            this.dgv房屋資料列表.Location = new System.Drawing.Point(21, 54);
            this.dgv房屋資料列表.Name = "dgv房屋資料列表";
            this.dgv房屋資料列表.RowHeadersWidth = 62;
            this.dgv房屋資料列表.RowTemplate.Height = 31;
            this.dgv房屋資料列表.Size = new System.Drawing.Size(437, 615);
            this.dgv房屋資料列表.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.groupBox2.Controls.Add(this.txt房數);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt價格);
            this.groupBox2.Controls.Add(this.txt坪數);
            this.groupBox2.Controls.Add(this.txt社區名稱);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt屋齡);
            this.groupBox2.Controls.Add(this.txt車位);
            this.groupBox2.Controls.Add(this.txt物件型態);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt行政區域);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt物件名稱);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(273, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 773);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "資料欄位";
            // 
            // txt房數
            // 
            this.txt房數.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt房數.Location = new System.Drawing.Point(144, 421);
            this.txt房數.Name = "txt房數";
            this.txt房數.Size = new System.Drawing.Size(223, 42);
            this.txt房數.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(37, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 36);
            this.label10.TabIndex = 18;
            this.label10.Text = "房數";
            // 
            // txt價格
            // 
            this.txt價格.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt價格.Location = new System.Drawing.Point(144, 562);
            this.txt價格.Name = "txt價格";
            this.txt價格.Size = new System.Drawing.Size(223, 42);
            this.txt價格.TabIndex = 17;
            // 
            // txt坪數
            // 
            this.txt坪數.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt坪數.Location = new System.Drawing.Point(144, 637);
            this.txt坪數.Name = "txt坪數";
            this.txt坪數.Size = new System.Drawing.Size(223, 42);
            this.txt坪數.TabIndex = 16;
            // 
            // txt社區名稱
            // 
            this.txt社區名稱.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt社區名稱.Location = new System.Drawing.Point(144, 708);
            this.txt社區名稱.Name = "txt社區名稱";
            this.txt社區名稱.Size = new System.Drawing.Size(278, 42);
            this.txt社區名稱.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(37, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 36);
            this.label9.TabIndex = 14;
            this.label9.Text = "價格";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(37, 643);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 36);
            this.label8.TabIndex = 13;
            this.label8.Text = "坪數";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(0, 714);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 36);
            this.label7.TabIndex = 12;
            this.label7.Text = "社區名稱";
            // 
            // txt屋齡
            // 
            this.txt屋齡.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt屋齡.Location = new System.Drawing.Point(144, 491);
            this.txt屋齡.Name = "txt屋齡";
            this.txt屋齡.Size = new System.Drawing.Size(223, 42);
            this.txt屋齡.TabIndex = 11;
            // 
            // txt車位
            // 
            this.txt車位.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt車位.Location = new System.Drawing.Point(144, 349);
            this.txt車位.Name = "txt車位";
            this.txt車位.Size = new System.Drawing.Size(223, 42);
            this.txt車位.TabIndex = 10;
            // 
            // txt物件型態
            // 
            this.txt物件型態.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt物件型態.Location = new System.Drawing.Point(144, 268);
            this.txt物件型態.Name = "txt物件型態";
            this.txt物件型態.Size = new System.Drawing.Size(223, 42);
            this.txt物件型態.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(37, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "屋齡";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(37, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "車位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "物件型態";
            // 
            // txt行政區域
            // 
            this.txt行政區域.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt行政區域.Location = new System.Drawing.Point(144, 186);
            this.txt行政區域.Name = "txt行政區域";
            this.txt行政區域.Size = new System.Drawing.Size(292, 42);
            this.txt行政區域.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "行政區域";
            // 
            // txt物件名稱
            // 
            this.txt物件名稱.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt物件名稱.Location = new System.Drawing.Point(144, 120);
            this.txt物件名稱.Name = "txt物件名稱";
            this.txt物件名稱.Size = new System.Drawing.Size(292, 31);
            this.txt物件名稱.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "物件名稱";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("微軟正黑體", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtid.Location = new System.Drawing.Point(144, 48);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(179, 42);
            this.txtid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(67, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.groupBox1.Controls.Add(this.btn清空欄位);
            this.groupBox1.Controls.Add(this.btn資料新增);
            this.groupBox1.Controls.Add(this.btn資料刪除);
            this.groupBox1.Controls.Add(this.btn資料修改);
            this.groupBox1.Controls.Add(this.btn資料搜尋);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 773);
            this.groupBox1.TabIndex = 3;
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
            // myhouseDataSet2
            // 
            this.myhouseDataSet2.DataSetName = "myhouseDataSet2";
            this.myhouseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataMember = "house";
            this.houseBindingSource.DataSource = this.myhouseDataSet2;
            // 
            // houseTableAdapter
            // 
            this.houseTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // 物件名稱DataGridViewTextBoxColumn
            // 
            this.物件名稱DataGridViewTextBoxColumn.DataPropertyName = "物件名稱";
            this.物件名稱DataGridViewTextBoxColumn.HeaderText = "物件名稱";
            this.物件名稱DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.物件名稱DataGridViewTextBoxColumn.Name = "物件名稱DataGridViewTextBoxColumn";
            this.物件名稱DataGridViewTextBoxColumn.Width = 150;
            // 
            // 價格DataGridViewTextBoxColumn
            // 
            this.價格DataGridViewTextBoxColumn.DataPropertyName = "價格";
            this.價格DataGridViewTextBoxColumn.HeaderText = "價格";
            this.價格DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.價格DataGridViewTextBoxColumn.Name = "價格DataGridViewTextBoxColumn";
            this.價格DataGridViewTextBoxColumn.Width = 150;
            // 
            // 社區名稱DataGridViewTextBoxColumn
            // 
            this.社區名稱DataGridViewTextBoxColumn.DataPropertyName = "社區名稱";
            this.社區名稱DataGridViewTextBoxColumn.HeaderText = "社區名稱";
            this.社區名稱DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.社區名稱DataGridViewTextBoxColumn.Name = "社區名稱DataGridViewTextBoxColumn";
            this.社區名稱DataGridViewTextBoxColumn.Width = 150;
            // 
            // 物件管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1225, 823);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "物件管理";
            this.Text = "物件管理";
            this.Load += new System.EventHandler(this.物件管理_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv房屋資料列表)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn顯示全部資料;
        private System.Windows.Forms.DataGridView dgv房屋資料列表;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt屋齡;
        private System.Windows.Forms.TextBox txt車位;
        private System.Windows.Forms.TextBox txt物件型態;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt行政區域;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt物件名稱;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn清空欄位;
        private System.Windows.Forms.Button btn資料新增;
        private System.Windows.Forms.Button btn資料刪除;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Button btn資料搜尋;
        private System.Windows.Forms.TextBox txt價格;
        private System.Windows.Forms.TextBox txt坪數;
        private System.Windows.Forms.TextBox txt社區名稱;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt房數;
        private System.Windows.Forms.Label label10;
        private myhouseDataSet2 myhouseDataSet2;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private myhouseDataSet2TableAdapters.houseTableAdapter houseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 物件名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 價格DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 社區名稱DataGridViewTextBoxColumn;
    }
}