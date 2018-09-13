namespace SubwayApplicationtest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.shortest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.least = new System.Windows.Forms.Button();
            this.Re = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shortest
            // 
            this.shortest.Location = new System.Drawing.Point(1617, 372);
            this.shortest.Name = "shortest";
            this.shortest.Size = new System.Drawing.Size(75, 23);
            this.shortest.TabIndex = 0;
            this.shortest.Text = "最短路径";
            this.shortest.UseVisualStyleBackColor = true;
            this.shortest.Click += new System.EventHandler(this.shortest_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1792, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1792, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1615, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "出发地";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1615, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "目的地";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1636, 175);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(256, 103);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1615, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "路径";
            // 
            // least
            // 
            this.least.Location = new System.Drawing.Point(1617, 310);
            this.least.Name = "least";
            this.least.Size = new System.Drawing.Size(75, 23);
            this.least.TabIndex = 7;
            this.least.Text = "最少换乘";
            this.least.UseVisualStyleBackColor = true;
            this.least.Click += new System.EventHandler(this.least_Click);
            // 
            // Re
            // 
            this.Re.Location = new System.Drawing.Point(1817, 310);
            this.Re.Name = "Re";
            this.Re.Size = new System.Drawing.Size(75, 23);
            this.Re.TabIndex = 8;
            this.Re.Text = "刷新";
            this.Re.UseVisualStyleBackColor = true;
            this.Re.Click += new System.EventHandler(this.Re_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(1817, 372);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 9;
            this.delete.Text = "删除/添加";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1636, 416);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(188, 53);
            this.textBox4.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.Re);
            this.Controls.Add(this.least);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.shortest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shortest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button least;
        private System.Windows.Forms.Button Re;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBox4;
    }
}

