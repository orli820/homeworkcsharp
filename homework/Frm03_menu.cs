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
    public partial class Frm03_menu : Form
    {
        public Frm03_menu()
        {
            InitializeComponent();
        }

        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;

        private void btn_1_Click(object sender, EventArgs e)
        {
            count1 += 1;
            txt_tprice.Text = "NT$"+(120 * count1);
            txt_oder.Text = "啤酒Beer x" + count1+",共NT$"+(120*count1)+"元";
        }


    }
}
