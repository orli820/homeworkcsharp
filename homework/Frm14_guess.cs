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


        Random r = new Random();
        public static int guess, count, min, max;

        public void G()
        {
            guess = r.Next(1, 100); //隨機數字是guess
        }

        public void Frm14_guess_Load(object sender, EventArgs e)  //打開表單產生隨機數字
        {
            G();
            min = 0;
            max = 100;
            //btnok.Enabled = true;
            //txtgu.Text = "";
        }

       


        public void SetLabelTest(string value)  //可以修改標籤
        {
            lab2.Text = value;
        }

        public void SetLabelTest2(string value)  //可以修改標籤
        {
            lab1.Text = value;
        }


        public void button1_Click(object sender, EventArgs e)  //叫出另一個視窗
        {
            Frm14_guess_1 frm141_1 = new Frm14_guess_1();
            frm141_1.Show(this);

        }


        public void btnans_Click(object sender, EventArgs e) //答案
        {
            MessageBox.Show("Anser:" + guess);
            G();
        }


    }
}
