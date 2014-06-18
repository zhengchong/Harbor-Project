namespace Harbor
{
    partial class VotageManagement
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.靠泊记录编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进口航次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出口航次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.航线 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.靠泊时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.离泊时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(599, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(70, 21);
            this.textBox4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "船舶名称";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(448, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 21);
            this.textBox3.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "船舶高度";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "船公司代码";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 21);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "船舶代码";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.靠泊记录编码,
            this.进口航次,
            this.出口航次,
            this.航线,
            this.靠泊时间,
            this.离泊时间});
            this.dataGridView1.Location = new System.Drawing.Point(13, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(692, 196);
            this.dataGridView1.TabIndex = 12;
            // 
            // 靠泊记录编码
            // 
            this.靠泊记录编码.HeaderText = "靠泊记录编码";
            this.靠泊记录编码.Name = "靠泊记录编码";
            // 
            // 进口航次
            // 
            this.进口航次.HeaderText = "进口航次";
            this.进口航次.Name = "进口航次";
            // 
            // 出口航次
            // 
            this.出口航次.HeaderText = "出口航次";
            this.出口航次.Name = "出口航次";
            // 
            // 航线
            // 
            this.航线.HeaderText = "航线";
            this.航线.Name = "航线";
            this.航线.Width = 148;
            // 
            // 靠泊时间
            // 
            this.靠泊时间.HeaderText = "靠泊时间";
            this.靠泊时间.Name = "靠泊时间";
            // 
            // 离泊时间
            // 
            this.离泊时间.HeaderText = "离泊时间";
            this.离泊时间.Name = "离泊时间";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // VotageManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 298);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "VotageManagement";
            this.Text = "船舶信息管理";
            this.Load += new System.EventHandler(this.VotageManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 靠泊记录编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进口航次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出口航次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 航线;
        private System.Windows.Forms.DataGridViewTextBoxColumn 靠泊时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 离泊时间;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}