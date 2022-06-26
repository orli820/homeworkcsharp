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
    public partial class Frm00_Con : Form
    {
        public Frm00_Con()
        {
            InitializeComponent();
        }


        Frm_Hello hll = new Frm_Hello();
        Frm02_loan fm2 = new Frm02_loan();
        Frm03_menu fm3 = new Frm03_menu();
        Frm04_scrip fm4 = new Frm04_scrip();

        private void button1_Click_1(object sender, EventArgs e)
        {
            fm2.Visible = false;
            fm3.Visible = false;
            fm4.Visible = false;

            hll.TopLevel = false;
            hll.Parent = this.splitContainer2.Panel2;
            hll.Visible = true;                                          
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            fm2.TopLevel = false;
            fm2.Parent = this.splitContainer2.Panel2;
            fm2.Visible = true;
           
            hll.Visible = false;
            fm3.Visible = false;
            fm4.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            fm3.TopLevel = false;
            fm3.Parent = this.splitContainer2.Panel2;
            fm3.Show();

            hll.Visible = false;
            fm2.Visible = false;
            fm4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            fm4.TopLevel = false;
            fm4.Parent = this.splitContainer2.Panel2;
            fm4.Show();

            hll.Visible = false;
            fm2.Visible = false;
            fm3.Visible = false;
        }
    }
}
