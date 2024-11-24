namespace WindowsFormsApp1.Forms
{
    partial class 客戶預約列表
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
            this.reserveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myhouseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myhouseDataSet2 = new WindowsFormsApp1.myhouseDataSet2();
            this.btn資料輸出 = new System.Windows.Forms.Button();
            this.myhouseDataSet1 = new WindowsFormsApp1.myhouseDataSet1();
            this.myhouseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reserveTableAdapter = new WindowsFormsApp1.myhouseDataSet2TableAdapters.reserveTableAdapter();
            this.dgv客戶預約列表 = new System.Windows.Forms.DataGridView();
            this.btn刪除 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reserveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv客戶預約列表)).BeginInit();
            this.SuspendLayout();
            // 
            // reserveBindingSource1
            // 
            this.reserveBindingSource1.DataMember = "reserve";
            this.reserveBindingSource1.DataSource = this.myhouseDataSet2BindingSource;
            // 
            // myhouseDataSet2BindingSource
            // 
            this.myhouseDataSet2BindingSource.DataSource = this.myhouseDataSet2;
            this.myhouseDataSet2BindingSource.Position = 0;
            // 
            // myhouseDataSet2
            // 
            this.myhouseDataSet2.DataSetName = "myhouseDataSet2";
            this.myhouseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn資料輸出
            // 
            this.btn資料輸出.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn資料輸出.Location = new System.Drawing.Point(928, 662);
            this.btn資料輸出.Name = "btn資料輸出";
            this.btn資料輸出.Size = new System.Drawing.Size(212, 63);
            this.btn資料輸出.TabIndex = 1;
            this.btn資料輸出.Text = "資料輸出";
            this.btn資料輸出.UseVisualStyleBackColor = true;
            this.btn資料輸出.Click += new System.EventHandler(this.btn資料輸出_Click);
            // 
            // myhouseDataSet1
            // 
            this.myhouseDataSet1.DataSetName = "myhouseDataSet1";
            this.myhouseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myhouseDataSet1BindingSource
            // 
            this.myhouseDataSet1BindingSource.DataSource = this.myhouseDataSet1;
            this.myhouseDataSet1BindingSource.Position = 0;
            // 
            // reserveBindingSource
            // 
            this.reserveBindingSource.DataMember = "reserve";
            this.reserveBindingSource.DataSource = this.myhouseDataSet2;
            // 
            // reserveTableAdapter
            // 
            this.reserveTableAdapter.ClearBeforeFill = true;
            // 
            // dgv客戶預約列表
            // 
            this.dgv客戶預約列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv客戶預約列表.Location = new System.Drawing.Point(12, 12);
            this.dgv客戶預約列表.Name = "dgv客戶預約列表";
            this.dgv客戶預約列表.RowHeadersWidth = 62;
            this.dgv客戶預約列表.RowTemplate.Height = 31;
            this.dgv客戶預約列表.Size = new System.Drawing.Size(1128, 614);
            this.dgv客戶預約列表.TabIndex = 3;
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(682, 667);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(203, 58);
            this.btn刪除.TabIndex = 4;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // 客戶預約列表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1163, 747);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.dgv客戶預約列表);
            this.Controls.Add(this.btn資料輸出);
            this.Name = "客戶預約列表";
            this.Text = "客戶預約列表";
            this.Load += new System.EventHandler(this.客戶預約列表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reserveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myhouseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reserveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv客戶預約列表)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn資料輸出;
        private System.Windows.Forms.BindingSource myhouseDataSet1BindingSource;
        private myhouseDataSet1 myhouseDataSet1;
        private myhouseDataSet2 myhouseDataSet2;
        private System.Windows.Forms.BindingSource reserveBindingSource;
        private myhouseDataSet2TableAdapters.reserveTableAdapter reserveTableAdapter;
        private System.Windows.Forms.BindingSource reserveBindingSource1;
        private System.Windows.Forms.BindingSource myhouseDataSet2BindingSource;
        private System.Windows.Forms.DataGridView dgv客戶預約列表;
        private System.Windows.Forms.Button btn刪除;
    }
}