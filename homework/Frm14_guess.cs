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

        Random r = new Random();
        public int guess, count, min, max;


        public void button2_Click(object sender, EventArgs e) //todo顯示答案
        {
            guess = r.Next(1, 100); //隨機數字是guess
            min = 0;
            max = 100;
            MessageBox.Show("Anser:" + guess);
        }


        public void SetLabelTest(string value)  //可以修改標籤
        {
            lab2.Text = value;
        }

        public void SetLabelTest2(string value)  //可以修改標籤
        {
            lab1.Text = value;
        }

    }
}
