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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 form2 = new Bai1();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai5 form3 = new Bai5();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai6 form4 = new Bai6();
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai7 form5 = new Bai7();  
            form5.ShowDialog(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bai8 form6 = new Bai8();  
            form6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai9 form7 = new Bai9();  
            form7.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bai10 form8 = new Bai10();
            form8.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bai12 form9 = new Bai12();
            form9.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bai13 form10 = new Bai13();
            form10.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Bai14 form14 = new Bai14();
            form14.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Bai15 form15 = new Bai15();
            form15.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bai16 form16 = new Bai16();
            form16.ShowDialog();
        }
    }
}
