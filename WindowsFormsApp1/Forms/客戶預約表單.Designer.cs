namespace WindowsFormsApp1.Forms
{
    partial class 客戶預約表單
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
            this.btn輸出資料 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn輸出資料
            // 
            this.btn輸出資料.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn輸出資料.Location = new System.Drawing.Point(906, 669);
            this.btn輸出資料.Name = "btn輸出資料";
            this.btn輸出資料.Size = new System.Drawing.Size(210, 66);
            this.btn輸出資料.TabIndex = 3;
            this.btn輸出資料.Text = "輸出資料";
            this.btn輸出資料.UseVisualStyleBackColor = true;
            this.btn輸出資料.Click += new System.EventHandler(this.btn輸出資料_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 398);
            this.dataGridView1.TabIndex = 2;
            // 
            // 客戶預約表單
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1149, 810);
            this.Controls.Add(this.btn輸出資料);
            this.Controls.Add(this.dataGridView1);
            this.Name = "客戶預約表單";
            this.Text = "客戶預約表單";
            this.Load += new System.EventHandler(this.客戶預約表單_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn輸出資料;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}