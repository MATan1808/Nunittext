namespace PrimeNumber
{
    partial class Form1
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btngui = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btngui1 = new System.Windows.Forms.Button();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtkqyear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.Color.Red;
            this.btnthoat.Location = new System.Drawing.Point(984, 419);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(95, 37);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số Nguyên Tố";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập Số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kết Quả";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(175, 92);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(138, 26);
            this.txta.TabIndex = 4;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(175, 200);
            this.txtkq.Name = "txtkq";
            this.txtkq.ReadOnly = true;
            this.txtkq.Size = new System.Drawing.Size(292, 26);
            this.txtkq.TabIndex = 5;
            // 
            // btngui
            // 
            this.btngui.Location = new System.Drawing.Point(396, 296);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(111, 36);
            this.btngui.TabIndex = 6;
            this.btngui.Text = "Gửi";
            this.btngui.UseVisualStyleBackColor = true;
            this.btngui.Click += new System.EventHandler(this.btngui_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btngui);
            this.panel1.Controls.Add(this.txta);
            this.panel1.Controls.Add(this.txtkq);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(539, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 364);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btngui1);
            this.panel2.Controls.Add(this.txtyear);
            this.panel2.Controls.Add(this.txtkqyear);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 364);
            this.panel2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Năm Nhuận";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btngui1
            // 
            this.btngui1.Location = new System.Drawing.Point(347, 296);
            this.btngui1.Name = "btngui1";
            this.btngui1.Size = new System.Drawing.Size(111, 36);
            this.btngui1.TabIndex = 6;
            this.btngui1.Text = "Gửi";
            this.btngui1.UseVisualStyleBackColor = true;
            this.btngui1.Click += new System.EventHandler(this.btngui1_Click);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(175, 92);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(138, 26);
            this.txtyear.TabIndex = 4;
            // 
            // txtkqyear
            // 
            this.txtkqyear.Location = new System.Drawing.Point(175, 200);
            this.txtkqyear.Name = "txtkqyear";
            this.txtkqyear.ReadOnly = true;
            this.txtkqyear.Size = new System.Drawing.Size(299, 26);
            this.txtkqyear.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập Năm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Kết Quả";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(524, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(8, 8);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnthoat);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Nunit_Ma_Nguyen_Nhat_Tan";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btngui;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btngui1;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtkqyear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

