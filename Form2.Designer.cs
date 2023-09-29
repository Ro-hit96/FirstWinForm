namespace FirstWinForm
{
    partial class Form2
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
            this.Eidlabel = new System.Windows.Forms.Label();
            this.enamelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BSallabel = new System.Windows.Forms.Label();
            this.DeptCmbx = new System.Windows.Forms.ComboBox();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.txtbasicsal = new System.Windows.Forms.TextBox();
            this.HRAlabel = new System.Windows.Forms.Label();
            this.HRAtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DaTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PFtxt = new System.Windows.Forms.TextBox();
            this.GrossSallbl = new System.Windows.Forms.Label();
            this.GSTxt = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.Displaybtn = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Eidlabel
            // 
            this.Eidlabel.AutoSize = true;
            this.Eidlabel.Location = new System.Drawing.Point(56, 53);
            this.Eidlabel.Name = "Eidlabel";
            this.Eidlabel.Size = new System.Drawing.Size(56, 20);
            this.Eidlabel.TabIndex = 0;
            this.Eidlabel.Text = "EmpId";
            this.Eidlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // enamelabel
            // 
            this.enamelabel.AutoSize = true;
            this.enamelabel.Location = new System.Drawing.Point(56, 92);
            this.enamelabel.Name = "enamelabel";
            this.enamelabel.Size = new System.Drawing.Size(88, 20);
            this.enamelabel.TabIndex = 1;
            this.enamelabel.Text = "Emp Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // BSallabel
            // 
            this.BSallabel.AutoSize = true;
            this.BSallabel.Location = new System.Drawing.Point(56, 168);
            this.BSallabel.Name = "BSallabel";
            this.BSallabel.Size = new System.Drawing.Size(96, 20);
            this.BSallabel.TabIndex = 3;
            this.BSallabel.Text = "Basic Salary";
            // 
            // DeptCmbx
            // 
            this.DeptCmbx.FormattingEnabled = true;
            this.DeptCmbx.Location = new System.Drawing.Point(199, 123);
            this.DeptCmbx.Name = "DeptCmbx";
            this.DeptCmbx.Size = new System.Drawing.Size(194, 28);
            this.DeptCmbx.TabIndex = 4;
            this.DeptCmbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Idtxt
            // 
            this.Idtxt.Location = new System.Drawing.Point(199, 47);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(194, 26);
            this.Idtxt.TabIndex = 5;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(199, 86);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(194, 26);
            this.nametxt.TabIndex = 6;
            // 
            // txtbasicsal
            // 
            this.txtbasicsal.Location = new System.Drawing.Point(199, 168);
            this.txtbasicsal.Name = "txtbasicsal";
            this.txtbasicsal.Size = new System.Drawing.Size(194, 26);
            this.txtbasicsal.TabIndex = 7;
            // 
            // HRAlabel
            // 
            this.HRAlabel.AutoSize = true;
            this.HRAlabel.Location = new System.Drawing.Point(61, 218);
            this.HRAlabel.Name = "HRAlabel";
            this.HRAlabel.Size = new System.Drawing.Size(44, 20);
            this.HRAlabel.TabIndex = 8;
            this.HRAlabel.Text = "HRA";
            // 
            // HRAtxt
            // 
            this.HRAtxt.Location = new System.Drawing.Point(199, 212);
            this.HRAtxt.Name = "HRAtxt";
            this.HRAtxt.ReadOnly = true;
            this.HRAtxt.Size = new System.Drawing.Size(194, 26);
            this.HRAtxt.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "TA";
            // 
            // TaTxt
            // 
            this.TaTxt.Location = new System.Drawing.Point(199, 252);
            this.TaTxt.Name = "TaTxt";
            this.TaTxt.ReadOnly = true;
            this.TaTxt.Size = new System.Drawing.Size(194, 26);
            this.TaTxt.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "DA";
            // 
            // DaTxt
            // 
            this.DaTxt.Location = new System.Drawing.Point(199, 291);
            this.DaTxt.Name = "DaTxt";
            this.DaTxt.ReadOnly = true;
            this.DaTxt.Size = new System.Drawing.Size(194, 26);
            this.DaTxt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "PF";
            // 
            // PFtxt
            // 
            this.PFtxt.Location = new System.Drawing.Point(199, 328);
            this.PFtxt.Name = "PFtxt";
            this.PFtxt.ReadOnly = true;
            this.PFtxt.Size = new System.Drawing.Size(194, 26);
            this.PFtxt.TabIndex = 15;
            // 
            // GrossSallbl
            // 
            this.GrossSallbl.AutoSize = true;
            this.GrossSallbl.Location = new System.Drawing.Point(61, 373);
            this.GrossSallbl.Name = "GrossSallbl";
            this.GrossSallbl.Size = new System.Drawing.Size(100, 20);
            this.GrossSallbl.TabIndex = 16;
            this.GrossSallbl.Text = "Gross Salary";
            // 
            // GSTxt
            // 
            this.GSTxt.Location = new System.Drawing.Point(199, 373);
            this.GSTxt.Name = "GSTxt";
            this.GSTxt.ReadOnly = true;
            this.GSTxt.Size = new System.Drawing.Size(194, 26);
            this.GSTxt.TabIndex = 17;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(492, 299);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(169, 35);
            this.BtnCalculate.TabIndex = 18;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Displaybtn
            // 
            this.Displaybtn.Location = new System.Drawing.Point(752, 295);
            this.Displaybtn.Name = "Displaybtn";
            this.Displaybtn.Size = new System.Drawing.Size(159, 42);
            this.Displaybtn.TabIndex = 19;
            this.Displaybtn.Text = "Display";
            this.Displaybtn.UseVisualStyleBackColor = true;
            this.Displaybtn.Click += new System.EventHandler(this.Displaybtn_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(521, 101);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(54, 20);
            this.lblmessage.TabIndex = 21;
            this.lblmessage.Text = "lblmsg";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 711);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.Displaybtn);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.GSTxt);
            this.Controls.Add(this.GrossSallbl);
            this.Controls.Add(this.PFtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HRAtxt);
            this.Controls.Add(this.HRAlabel);
            this.Controls.Add(this.txtbasicsal);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.Idtxt);
            this.Controls.Add(this.DeptCmbx);
            this.Controls.Add(this.BSallabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enamelabel);
            this.Controls.Add(this.Eidlabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Eidlabel;
        private System.Windows.Forms.Label enamelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BSallabel;
        private System.Windows.Forms.ComboBox DeptCmbx;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox txtbasicsal;
        private System.Windows.Forms.Label HRAlabel;
        private System.Windows.Forms.TextBox HRAtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DaTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PFtxt;
        private System.Windows.Forms.Label GrossSallbl;
        private System.Windows.Forms.TextBox GSTxt;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button Displaybtn;
        private System.Windows.Forms.Label lblmessage;
    }
}