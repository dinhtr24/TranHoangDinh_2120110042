namespace WindowsFormsApp1
{
    partial class Bai13
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
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btOK_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Location = new System.Drawing.Point(12, 12);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(382, 21);
            this.cb_Faculty.TabIndex = 0;
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(382, 183);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btOK_Click
            // 
            this.btOK_Click.Location = new System.Drawing.Point(319, 228);
            this.btOK_Click.Name = "btOK_Click";
            this.btOK_Click.Size = new System.Drawing.Size(75, 23);
            this.btOK_Click.TabIndex = 2;
            this.btOK_Click.Text = "OK";
            this.btOK_Click.UseVisualStyleBackColor = true;
            this.btOK_Click.Click += new System.EventHandler(this.btOK_Click_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 287);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btOK_Click);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Faculty;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btOK_Click;
        private System.Windows.Forms.Button button2;
    }
}