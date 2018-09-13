namespace SubwayApplicationtest {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.del = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delE1 = new System.Windows.Forms.TextBox();
            this.delE2 = new System.Windows.Forms.TextBox();
            this.delEdge = new System.Windows.Forms.Button();
            this.AddName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddlineNo = new System.Windows.Forms.TextBox();
            this.PointX = new System.Windows.Forms.TextBox();
            this.PointY = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddSt = new System.Windows.Forms.Button();
            this.AddE1 = new System.Windows.Forms.TextBox();
            this.AddE2 = new System.Windows.Forms.TextBox();
            this.AddWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddEdge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(524, 43);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(100, 21);
            this.del.TabIndex = 0;
            this.del.Text = "删除站点";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(69, 43);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 21);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "站名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "相邻站";
            // 
            // delE1
            // 
            this.delE1.Location = new System.Drawing.Point(69, 96);
            this.delE1.Name = "delE1";
            this.delE1.Size = new System.Drawing.Size(100, 21);
            this.delE1.TabIndex = 4;
            // 
            // delE2
            // 
            this.delE2.Location = new System.Drawing.Point(217, 96);
            this.delE2.Name = "delE2";
            this.delE2.Size = new System.Drawing.Size(100, 21);
            this.delE2.TabIndex = 5;
            // 
            // delEdge
            // 
            this.delEdge.Location = new System.Drawing.Point(524, 96);
            this.delEdge.Name = "delEdge";
            this.delEdge.Size = new System.Drawing.Size(100, 23);
            this.delEdge.TabIndex = 6;
            this.delEdge.Text = "删除边";
            this.delEdge.UseVisualStyleBackColor = true;
            this.delEdge.Click += new System.EventHandler(this.delEdge_Click);
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(69, 199);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(100, 21);
            this.AddName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "站名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "线路";
            // 
            // AddlineNo
            // 
            this.AddlineNo.Location = new System.Drawing.Point(69, 163);
            this.AddlineNo.Name = "AddlineNo";
            this.AddlineNo.Size = new System.Drawing.Size(100, 21);
            this.AddlineNo.TabIndex = 10;
            // 
            // PointX
            // 
            this.PointX.Location = new System.Drawing.Point(217, 199);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(100, 21);
            this.PointX.TabIndex = 11;
            // 
            // PointY
            // 
            this.PointY.Location = new System.Drawing.Point(367, 199);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(100, 21);
            this.PointY.TabIndex = 12;
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(194, 199);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(23, 12);
            this.X.TabIndex = 13;
            this.X.Text = "X：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "Y：";
            // 
            // AddSt
            // 
            this.AddSt.Location = new System.Drawing.Point(524, 199);
            this.AddSt.Name = "AddSt";
            this.AddSt.Size = new System.Drawing.Size(100, 23);
            this.AddSt.TabIndex = 15;
            this.AddSt.Text = "添加站点";
            this.AddSt.UseVisualStyleBackColor = true;
            this.AddSt.Click += new System.EventHandler(this.AddSt_Click);
            // 
            // AddE1
            // 
            this.AddE1.Location = new System.Drawing.Point(69, 244);
            this.AddE1.Name = "AddE1";
            this.AddE1.Size = new System.Drawing.Size(100, 21);
            this.AddE1.TabIndex = 16;
            // 
            // AddE2
            // 
            this.AddE2.Location = new System.Drawing.Point(217, 244);
            this.AddE2.Name = "AddE2";
            this.AddE2.Size = new System.Drawing.Size(100, 21);
            this.AddE2.TabIndex = 17;
            // 
            // AddWeight
            // 
            this.AddWeight.Location = new System.Drawing.Point(367, 244);
            this.AddWeight.Name = "AddWeight";
            this.AddWeight.Size = new System.Drawing.Size(100, 21);
            this.AddWeight.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "相邻边";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "距离：";
            // 
            // AddEdge
            // 
            this.AddEdge.Location = new System.Drawing.Point(524, 247);
            this.AddEdge.Name = "AddEdge";
            this.AddEdge.Size = new System.Drawing.Size(100, 23);
            this.AddEdge.TabIndex = 21;
            this.AddEdge.Text = "添加边";
            this.AddEdge.UseVisualStyleBackColor = true;
            this.AddEdge.Click += new System.EventHandler(this.AddEdge_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 427);
            this.Controls.Add(this.AddEdge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddWeight);
            this.Controls.Add(this.AddE2);
            this.Controls.Add(this.AddE1);
            this.Controls.Add(this.AddSt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.X);
            this.Controls.Add(this.PointY);
            this.Controls.Add(this.PointX);
            this.Controls.Add(this.AddlineNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddName);
            this.Controls.Add(this.delEdge);
            this.Controls.Add(this.delE2);
            this.Controls.Add(this.delE1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.del);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox delE1;
        private System.Windows.Forms.TextBox delE2;
        private System.Windows.Forms.Button delEdge;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddlineNo;
        private System.Windows.Forms.TextBox PointX;
        private System.Windows.Forms.TextBox PointY;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddSt;
        private System.Windows.Forms.TextBox AddE1;
        private System.Windows.Forms.TextBox AddE2;
        private System.Windows.Forms.TextBox AddWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddEdge;
    }
}