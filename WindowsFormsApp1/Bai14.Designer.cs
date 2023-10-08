namespace WindowsFormsApp1
{
    partial class Bai14
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.ckDiscount = new System.Windows.Forms.CheckBox();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.rTBResult = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(373, 20);
            this.tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giới tính";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(66, 112);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 17);
            this.rbMale.TabIndex = 2;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(187, 112);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(39, 17);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // ckDiscount
            // 
            this.ckDiscount.AutoSize = true;
            this.ckDiscount.Location = new System.Drawing.Point(12, 166);
            this.ckDiscount.Name = "ckDiscount";
            this.ckDiscount.Size = new System.Drawing.Size(67, 17);
            this.ckDiscount.TabIndex = 4;
            this.ckDiscount.Text = "Giảm giá";
            this.ckDiscount.UseVisualStyleBackColor = true;
            this.ckDiscount.CheckedChanged += new System.EventHandler(this.ckDiscount_CheckedChanged);
            // 
            // tbDiscount
            // 
            this.tbDiscount.Location = new System.Drawing.Point(85, 163);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(300, 20);
            this.tbDiscount.TabIndex = 5;
            // 
            // rTBResult
            // 
            this.rTBResult.Location = new System.Drawing.Point(12, 189);
            this.rTBResult.Name = "rTBResult";
            this.rTBResult.Size = new System.Drawing.Size(373, 103);
            this.rTBResult.TabIndex = 6;
            this.rTBResult.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(229, 321);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 23);
            this.btRun.TabIndex = 8;
            this.btRun.Text = "Tính tiền";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 367);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rTBResult);
            this.Controls.Add(this.tbDiscount);
            this.Controls.Add(this.ckDiscount);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "Form14";
            this.Text = "Form14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox ckDiscount;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.RichTextBox rTBResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRun;
    }
}