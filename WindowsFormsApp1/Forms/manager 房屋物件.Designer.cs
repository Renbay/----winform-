namespace WindowsFormsApp1.Forms
{
    partial class manager_房屋物件
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
            this.houseTableAdapter = new WindowsFormsApp1.myhouseDataSetTableAdapters.houseTableAdapter();
            this.lbl總筆數 = new System.Windows.Forms.Label();
            this.cbox房數 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn清除資料 = new System.Windows.Forms.Button();
            this.btn查詢 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt價格萬2 = new System.Windows.Forms.TextBox();
            this.txt價格萬1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt屋齡年2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt屋齡年1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox車位 = new System.Windows.Forms.ComboBox();
            this.tableAdapterManager = new WindowsFormsApp1.myhouseDataSetTableAdapters.TableAdapterManager();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.houseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.坪數 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.社區名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myhouseDataSet = new WindowsFormsApp1.myhouseDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox行政區域 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox物件型態 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.houseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // houseTableAdapter
            // 
            this.houseTableAdapter.ClearBeforeFill = true;
            // 
            // lbl總筆數
            // 
            this.lbl總筆數.AutoSize = true;
            this.lbl總筆數.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總筆數.Location = new System.Drawing.Point(905, 495);
            this.lbl總筆數.Name = "lbl總筆數";
            this.lbl總筆數.Size = new System.Drawing.Size(186, 36);
            this.lbl總筆數.TabIndex = 48;
            this.lbl總筆數.Text = "總筆數: 共0筆";
            // 
            // cbox房數
            // 
            this.cbox房數.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox房數.FormattingEnabled = true;
            this.cbox房數.Location = new System.Drawing.Point(411, 524);
            this.cbox房數.Name = "cbox房數";
            this.cbox房數.Size = new System.Drawing.Size(174, 39);
            this.cbox房數.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(347, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 45;
            this.label4.Text = "房數";
            // 
            // btn清除資料
            // 
            this.btn清除資料.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除資料.Location = new System.Drawing.Point(896, 635);
            this.btn清除資料.Name = "btn清除資料";
            this.btn清除資料.Size = new System.Drawing.Size(157, 60);
            this.btn清除資料.TabIndex = 44;
            this.btn清除資料.Text = "清除條件";
            this.btn清除資料.UseVisualStyleBackColor = true;
            this.btn清除資料.Click += new System.EventHandler(this.btn清除資料_Click);
            // 
            // btn查詢
            // 
            this.btn查詢.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn查詢.Location = new System.Drawing.Point(693, 635);
            this.btn查詢.Name = "btn查詢";
            this.btn查詢.Size = new System.Drawing.Size(165, 60);
            this.btn查詢.TabIndex = 43;
            this.btn查詢.Text = "查詢";
            this.btn查詢.UseVisualStyleBackColor = true;
            this.btn查詢.Click += new System.EventHandler(this.btn查詢_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(613, 654);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 31);
            this.label8.TabIndex = 42;
            this.label8.Text = "萬";
            // 
            // txt價格萬2
            // 
            this.txt價格萬2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt價格萬2.Location = new System.Drawing.Point(541, 647);
            this.txt價格萬2.Name = "txt價格萬2";
            this.txt價格萬2.Size = new System.Drawing.Size(66, 39);
            this.txt價格萬2.TabIndex = 41;
            // 
            // txt價格萬1
            // 
            this.txt價格萬1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt價格萬1.Location = new System.Drawing.Point(411, 647);
            this.txt價格萬1.Name = "txt價格萬1";
            this.txt價格萬1.Size = new System.Drawing.Size(66, 39);
            this.txt價格萬1.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(347, 654);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 31);
            this.label10.TabIndex = 38;
            this.label10.Text = "價格";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(613, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 31);
            this.label7.TabIndex = 37;
            this.label7.Text = "年";
            // 
            // txt屋齡年2
            // 
            this.txt屋齡年2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt屋齡年2.Location = new System.Drawing.Point(541, 581);
            this.txt屋齡年2.Name = "txt屋齡年2";
            this.txt屋齡年2.Size = new System.Drawing.Size(66, 39);
            this.txt屋齡年2.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(483, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 31);
            this.label6.TabIndex = 35;
            this.label6.Text = "年 ~";
            // 
            // txt屋齡年1
            // 
            this.txt屋齡年1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt屋齡年1.Location = new System.Drawing.Point(411, 581);
            this.txt屋齡年1.Name = "txt屋齡年1";
            this.txt屋齡年1.Size = new System.Drawing.Size(66, 39);
            this.txt屋齡年1.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(347, 588);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 33;
            this.label5.Text = "屋齡";
            // 
            // cbox車位
            // 
            this.cbox車位.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox車位.FormattingEnabled = true;
            this.cbox車位.Location = new System.Drawing.Point(147, 646);
            this.cbox車位.Name = "cbox車位";
            this.cbox車位.Size = new System.Drawing.Size(174, 39);
            this.cbox車位.TabIndex = 32;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.houseTableAdapter = this.houseTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.myhouseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(483, 654);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 31);
            this.label9.TabIndex = 40;
            this.label9.Text = "萬 ~";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(83, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "車位";
            // 
            // houseDataGridView
            // 
            this.houseDataGridView.AutoGenerateColumns = false;
            this.houseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.houseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.坪數,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.社區名稱});
            this.houseDataGridView.DataSource = this.houseBindingSource;
            this.houseDataGridView.Location = new System.Drawing.Point(12, 46);
            this.houseDataGridView.Name = "houseDataGridView";
            this.houseDataGridView.RowHeadersWidth = 20;
            this.houseDataGridView.RowTemplate.Height = 31;
            this.houseDataGridView.Size = new System.Drawing.Size(1196, 431);
            this.houseDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "物件名稱";
            this.dataGridViewTextBoxColumn2.HeaderText = "物件名稱";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "屋齡";
            this.dataGridViewTextBoxColumn7.HeaderText = "屋齡";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 40;
            // 
            // 坪數
            // 
            this.坪數.DataPropertyName = "坪數";
            this.坪數.HeaderText = "坪數";
            this.坪數.MinimumWidth = 8;
            this.坪數.Name = "坪數";
            this.坪數.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "行政區域";
            this.dataGridViewTextBoxColumn3.HeaderText = "行政區域";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "物件型態";
            this.dataGridViewTextBoxColumn4.HeaderText = "物件型態";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "車位";
            this.dataGridViewTextBoxColumn5.HeaderText = "車位";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "房數";
            this.dataGridViewTextBoxColumn6.HeaderText = "房數";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 40;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "價格";
            this.dataGridViewTextBoxColumn8.HeaderText = "價格";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 60;
            // 
            // 社區名稱
            // 
            this.社區名稱.DataPropertyName = "社區名稱";
            this.社區名稱.HeaderText = "社區名稱";
            this.社區名稱.MinimumWidth = 8;
            this.社區名稱.Name = "社區名稱";
            this.社區名稱.Width = 150;
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataMember = "house";
            this.houseBindingSource.DataSource = this.myhouseDataSet;
            // 
            // myhouseDataSet
            // 
            this.myhouseDataSet.DataSetName = "myhouseDataSet";
            this.myhouseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(35, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 29;
            this.label2.Text = "物件類型";
            // 
            // cbox行政區域
            // 
            this.cbox行政區域.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox行政區域.FormattingEnabled = true;
            this.cbox行政區域.Location = new System.Drawing.Point(147, 524);
            this.cbox行政區域.Name = "cbox行政區域";
            this.cbox行政區域.Size = new System.Drawing.Size(174, 39);
            this.cbox行政區域.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(35, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "行政區域";
            // 
            // cbox物件型態
            // 
            this.cbox物件型態.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbox物件型態.FormattingEnabled = true;
            this.cbox物件型態.Location = new System.Drawing.Point(147, 585);
            this.cbox物件型態.Name = "cbox物件型態";
            this.cbox物件型態.Size = new System.Drawing.Size(174, 39);
            this.cbox物件型態.TabIndex = 30;
            // 
            // manager_房屋物件
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1220, 763);
            this.Controls.Add(this.lbl總筆數);
            this.Controls.Add(this.cbox房數);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn清除資料);
            this.Controls.Add(this.btn查詢);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt價格萬2);
            this.Controls.Add(this.txt價格萬1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt屋齡年2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt屋齡年1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbox車位);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.houseDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbox行政區域);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox物件型態);
            this.Name = "manager_房屋物件";
            this.Text = "manager_房屋物件";
            this.Load += new System.EventHandler(this.manager_房屋物件_Load);
            ((System.ComponentModel.ISupportInitialize)(this.houseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myhouseDataSetTableAdapters.houseTableAdapter houseTableAdapter;
        private System.Windows.Forms.Label lbl總筆數;
        private System.Windows.Forms.ComboBox cbox房數;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn清除資料;
        private System.Windows.Forms.Button btn查詢;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt價格萬2;
        private System.Windows.Forms.TextBox txt價格萬1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt屋齡年2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt屋齡年1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox車位;
        private myhouseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView houseDataGridView;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private myhouseDataSet myhouseDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbox行政區域;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox物件型態;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 坪數;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn 社區名稱;
    }
}