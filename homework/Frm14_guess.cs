using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Frm14_guess : Form
    {
        public Frm14_guess()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Frm14_guess_1 frm141_1 = new Frm14_guess_1();
            frm141_1.Show();
        }

        public void button2_Click(object sender, EventArgs e) //todo顯示答案
        {

        }

        public void lab1_Click(object sender, EventArgs e)
        {

        }

        public void setlab (string value)
        {
            lab1.Text = value;
        }
    }
}
