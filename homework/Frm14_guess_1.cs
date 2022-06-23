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
    public partial class Frm14_guess_1 : Form
    {
        public Frm14_guess_1()
        {
            InitializeComponent();
        }

        int guess, count, min, max;

        

        private void Frm14_guess_1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            guess = r.Next(1, 100);
            min = 0;
            max = 100;
            btnok.Enabled = true;
            txtgu.Text = "";

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            int myguess = 0;
            if (int.TryParse(txtgu.Text,out myguess))
            {
                if(myguess>=1 && myguess < 100)
                {
                    if (myguess == guess)
                    {
                        
                       
                    }
                }
            }
        }
    }
}
