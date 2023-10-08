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
    public partial class Bai10 : Form
    {
        decimal workingMemory = 0;
        string opr = "";
        public Bai10()
        {
            InitializeComponent();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            rTBDisplay.Text += bt0.Text;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            rTBDisplay.Text += bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            rTBDisplay.Text += bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            rTBDisplay.Text += bt3.Text;
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            opr = btPlus.Text;
            workingMemory = decimal.Parse(rTBDisplay.Text);
            rTBDisplay.Clear();
        }

        private void btMul_Click(object sender, EventArgs e)
        {
            opr = btMul.Text;
            workingMemory = decimal.Parse(rTBDisplay.Text);
            rTBDisplay.Clear();
        }

        private void btDot_Click(object sender, EventArgs e)
        {
            //btDot.Click += new EventHandler(btDot_Click);
            rTBDisplay.Clear();
        }

        private void btEquals_Click(object sender, EventArgs e)
        {
            decimal secondValue = decimal.Parse(rTBDisplay.Text);
            if (opr == "+")
                rTBDisplay.Text = (workingMemory + secondValue).ToString();
            if (opr == "*")
                rTBDisplay.Text = (workingMemory * secondValue).ToString();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
