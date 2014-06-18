namespace Harbor
{
    partial class ContainerManagement
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.进港记录编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进港类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进港方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进港车次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进港船次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进港船舶编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出港方式 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出港车次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出港拖车代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出港船舶代码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.进港时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出港时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.温度 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "箱号";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "箱型";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(212, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "高度";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 21);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "长度";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(487, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(70, 21);
            this.textBox4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "箱主";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(610, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(70, 21);
            this.textBox5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.进港记录编码,
            this.进港类型,
            this.进港方式,
            this.进港车次,
            this.进港船次,
            this.进港船舶编码,
            this.出港方式,
            this.出港车次,
            this.出港拖车代码,
            this.出港船舶代码,
            this.进港时间,
            this.出港时间,
            this.温度});
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(693, 196);
            this.dataGridView1.TabIndex = 2;
            // 
            // 进港记录编码
            // 
            this.进港记录编码.HeaderText = "进港记录编码";
            this.进港记录编码.Name = "进港记录编码";
            // 
            // 进港类型
            // 
            this.进港类型.HeaderText = "进港类型";
            this.进港类型.Name = "进港类型";
            // 
            // 进港方式
            // 
            this.进港方式.HeaderText = "进港方式";
            this.进港方式.Name = "进港方式";
            // 
            // 进港车次
            // 
            this.进港车次.HeaderText = "进港车次";
            this.进港车次.Name = "进港车次";
            // 
            // 进港船次
            // 
            this.进港船次.HeaderText = "进港船次";
            this.进港船次.Name = "进港船次";
            // 
            // 进港船舶编码
            // 
            this.进港船舶编码.HeaderText = "进港船舶编码";
            this.进港船舶编码.Name = "进港船舶编码";
            // 
            // 出港方式
            // 
            this.出港方式.HeaderText = "出港方式";
            this.出港方式.Name = "出港方式";
            // 
            // 出港车次
            // 
            this.出港车次.HeaderText = "出港车次";
            this.出港车次.Name = "出港车次";
            // 
            // 出港拖车代码
            // 
            this.出港拖车代码.HeaderText = "出港拖车代码";
            this.出港拖车代码.Name = "出港拖车代码";
            // 
            // 出港船舶代码
            // 
            this.出港船舶代码.HeaderText = "出港船舶代码";
            this.出港船舶代码.Name = "出港船舶代码";
            // 
            // 进港时间
            // 
            this.进港时间.HeaderText = "进港时间";
            this.进港时间.Name = "进港时间";
            // 
            // 出港时间
            // 
            this.出港时间.HeaderText = "出港时间";
            this.出港时间.Name = "出港时间";
            // 
            // 温度
            // 
            this.温度.HeaderText = "温度";
            this.温度.Name = "温度";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "取消";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 263);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ContainerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 298);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ContainerManagement";
            this.Text = "集装箱管理窗口";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进港记录编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进港类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进港方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进港车次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进港船次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进港船舶编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出港方式;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出港车次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出港拖车代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出港船舶代码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 进港时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出港时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 温度;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}