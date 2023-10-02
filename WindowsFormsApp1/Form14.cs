using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            string disc = "";
            if (rbMale.Checked == true) 
                msg += "Ông ";
            if (rbFemale.Checked == true)
                msg += "Bà ";
            if (ckDiscount.Checked == true)
                disc = tbDiscount.Text;
            rTBResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + "%" + "\r\n";
        }

        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }
    }
}
