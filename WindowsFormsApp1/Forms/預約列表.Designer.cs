namespace WindowsFormsApp1.Forms
{
    partial class 預約列表
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
            this.dgv預約列表 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp預約日期 = new System.Windows.Forms.DateTimePicker();
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn確定 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv預約列表)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv預約列表
            // 
            this.dgv預約列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv預約列表.Location = new System.Drawing.Point(34, 24);
            this.dgv預約列表.Name = "dgv預約列表";
            this.dgv預約列表.RowHeadersWidth = 62;
            this.dgv預約列表.RowTemplate.Height = 31;
            this.dgv預約列表.Size = new System.Drawing.Size(1149, 477);
            this.dgv預約列表.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(27, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "預約日期";
            // 
            // dtp預約日期
            // 
            this.dtp預約日期.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtp預約日期.Location = new System.Drawing.Point(178, 546);
            this.dtp預約日期.Name = "dtp預約日期";
            this.dtp預約日期.Size = new System.Drawing.Size(320, 45);
            this.dtp預約日期.TabIndex = 2;
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(788, 745);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(183, 51);
            this.btn刪除.TabIndex = 3;
            this.btn刪除.Text = "刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn確定
            // 
            this.btn確定.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn確定.Location = new System.Drawing.Point(1000, 745);
            this.btn確定.Name = "btn確定";
            this.btn確定.Size = new System.Drawing.Size(183, 51);
            this.btn確定.TabIndex = 4;
            this.btn確定.Text = "確定";
            this.btn確定.UseVisualStyleBackColor = true;
            this.btn確定.Click += new System.EventHandler(this.btn確定_Click);
            // 
            // 預約列表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1215, 808);
            this.Controls.Add(this.btn確定);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.dtp預約日期);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv預約列表);
            this.Name = "預約列表";
            this.Text = "預約列表";
            this.Load += new System.EventHandler(this.預約列表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv預約列表)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv預約列表;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp預約日期;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn確定;
    }
}