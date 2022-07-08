using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace homework
{
    public partial class Frm15_clo : Form
    {
        public Frm15_clo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)  //頁面載入時獲取當前時間
        {
            labtime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        bool b = false;
        bool flag = true;

        int h, m, s;

        private void ckbxtime_CheckedChanged(object sender, EventArgs e)
        {
            h = int.Parse(cmbxh.Text);
            m = int.Parse(cmbxm.Text);
            s = int.Parse(cmbxs.Text);
        }

        public void timer1_Tick(object sender, EventArgs e)    //計時器的事件
        {
            labtime.Text = DateTime.Now.ToString("HH:mm:ss");  // upade  every second                                                                
            if (h == DateTime.Now.Hour && m == DateTime.Now.Minute && s == DateTime.Now.Second && ckbxtime.Checked/*&& b*/)
            //判斷有沒有符合時分秒
            {
                b = true;  //當b是true的時候判斷下面
            }
            if (b && ckbxtime.Checked)   //b是true有打勾 就換顏色
            {
                if(flag) labtime.ForeColor = Color.Red;
                else labtime.ForeColor = Color.Yellow;
                flag = !flag;
            }           
        }
    }
  }
        

