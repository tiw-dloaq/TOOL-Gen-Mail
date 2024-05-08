namespace Tool_GenMail
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
            this.btnGenMail = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstMailGen = new System.Windows.Forms.ListBox();
            this.txtCountMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapDomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenMail
            // 
            this.btnGenMail.Location = new System.Drawing.Point(417, 76);
            this.btnGenMail.Name = "btnGenMail";
            this.btnGenMail.Size = new System.Drawing.Size(146, 61);
            this.btnGenMail.TabIndex = 0;
            this.btnGenMail.Text = "Gen Mail";
            this.btnGenMail.UseVisualStyleBackColor = true;
            this.btnGenMail.Click += new System.EventHandler(this.btnGenMail_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập Tên";
            // 
            // lstMailGen
            // 
            this.lstMailGen.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lstMailGen.FormattingEnabled = true;
            this.lstMailGen.ItemHeight = 16;
            this.lstMailGen.Location = new System.Drawing.Point(88, 54);
            this.lstMailGen.Name = "lstMailGen";
            this.lstMailGen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMailGen.Size = new System.Drawing.Size(257, 276);
            this.lstMailGen.TabIndex = 4;
            this.lstMailGen.SelectedIndexChanged += new System.EventHandler(this.lstMailGen_SelectedIndexChanged);
            // 
            // txtCountMail
            // 
            this.txtCountMail.Location = new System.Drawing.Point(514, 26);
            this.txtCountMail.Name = "txtCountMail";
            this.txtCountMail.Size = new System.Drawing.Size(98, 22);
            this.txtCountMail.TabIndex = 5;
            this.txtCountMail.TextChanged += new System.EventHandler(this.txtCountMail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số Lượng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNhapDomain
            // 
            this.txtNhapDomain.Location = new System.Drawing.Point(370, 26);
            this.txtNhapDomain.Name = "txtNhapDomain";
            this.txtNhapDomain.Size = new System.Drawing.Size(128, 22);
            this.txtNhapDomain.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhập Domain";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(365, 296);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(128, 34);
            this.btnSaveFile.TabIndex = 10;
            this.btnSaveFile.Text = "Lưu File";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 343);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhapDomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCountMail);
            this.Controls.Add(this.lstMailGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGenMail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenMail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstMailGen;
        private System.Windows.Forms.TextBox txtCountMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhapDomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveFile;
    }
}

