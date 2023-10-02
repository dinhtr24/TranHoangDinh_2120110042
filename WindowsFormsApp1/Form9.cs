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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_Faculty.SelectedIndex;
            rTBDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = cb_Faculty.SelectedItem.ToString();
            rTBDisplay.Text = "Bạn là sinh viên khoa thứ: " + item;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            cb_Faculty.SelectedIndex = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rTBDisplay.Clear();
        }
    }
}
