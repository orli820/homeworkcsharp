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
    public partial class Frm04_scrip : Form
    {
        public Frm04_scrip()
        {
            InitializeComponent();
        }

        string result;
        decimal score = 0;

        internal void button1_Click(object sender, EventArgs e)
        {
            Score sco;
            sco.studentName = txtname.Text;
            if (decimal.TryParse(txtchi.Text, out score))
            {
                sco.scoreChi = decimal.Parse(txtchi.Text);                
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txtchi.Text = "";                
                txtchi.Focus();
                return;
            }
            
            if (decimal.TryParse(txteng.Text, out score))
            {
                sco.scoreEng = decimal.Parse(txteng.Text);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txteng.Text = "";               
                txteng.Focus();
                return;
            }

            if (decimal.TryParse(txtmat.Text, out score))
            {
                sco.scoreMat = decimal.Parse(txtmat.Text); ;
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txtmat.Text = "";          
                txtmat.Focus();
                return;
            }

            sco.scoreChi = decimal.Parse(txtchi.Text);
            sco.scoreEng = decimal.Parse(txteng.Text);
            sco.scoreMat = decimal.Parse(txtmat.Text);
            result = $"姓名：{sco.studentName}\r\n國文：{sco.scoreChi}\r\n英文：{sco.scoreEng}\r\n數學：{sco.scoreMat}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsco.Text = result;
        }

        string b = "";
        string c = "";

        private void button3_Click(object sender, EventArgs e)
        {
            int[] a = new int[3] { Convert.ToInt32(txtchi.Text), Convert.ToInt32(txteng.Text), Convert.ToInt32(txtmat.Text) };
            for (int i = 0; i < a.Length; i++)
            {
                if (a[0] < a[i]) 
                {
                    a[0] = a[i];
                    b = $"最高成績為:{a[0]}\r\n";
                }
            }

            int[] x = new int[3] { Convert.ToInt32(txtchi.Text), Convert.ToInt32(txteng.Text), Convert.ToInt32(txtmat.Text) };
            for (int i = 0; i < a.Length; i++)
            {
                if (x[0] > x[i])
                {
                    x[0] = x[i];
                    c = $"最低成績為:{x[0]}";
                }
            }
            txthigh.Text = b+c;
        }
    }
}
