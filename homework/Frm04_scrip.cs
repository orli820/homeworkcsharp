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
        
        internal void button1_Click(object sender, EventArgs e)
        {
            Score sco;
            sco.studentName = txtname.Text;
            sco.scoreChi = decimal.Parse( txtchi.Text);
            sco.scoreEng = decimal.Parse(txteng.Text);
            sco.scoreMat = decimal.Parse(txtmat.Text);
            result = $"姓名：{sco.studentName}\r\n國文：{sco.scoreChi}\r\n英文：{sco.scoreEng}\r\n數學：{sco.scoreMat}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtsco.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Score sco;
            int[] a ={ Convert.ToInt32( txtchi.Text), Convert.ToInt32(txteng.Text), Convert.ToInt32(txtmat.Text) };
            
        }
}
