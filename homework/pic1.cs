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
    public partial class pic1 : Form
    {
        public pic1()
        {
            InitializeComponent();
        }
        //public string str2;

        //public pic1(string oo)  //建構函式
        //{
        //    InitializeComponent();
        //    str2 = oo;   //here
        //}
        
        

        public Image Imagebox
        {
            set
            {
                Frm13_pic f13 = new Frm13_pic();                
                this.pictureBox1.Image = value;                
                this.pictureBox1.Size = value.Size;
            }
        }

        public void pic1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null);
            pictureBox1.Dispose();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Frm13_pic f13 = new Frm13_pic();
            //this.pictureBox1.BackgroundImage = f13.pcb1.Image;
        }
    }
}
