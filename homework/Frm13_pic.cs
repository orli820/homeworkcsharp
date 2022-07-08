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
    public partial class Frm13_pic : Form
    {
        List<string> filesnames = new List<string>();

        public Frm13_pic()
        {
            InitializeComponent();
        }

        //Image G1;
        
        public void pcb1_Click(object sender, EventArgs e)
        {
            pic1 p1 = new pic1();           
            p1.Show();        
        }
       

    }
}
