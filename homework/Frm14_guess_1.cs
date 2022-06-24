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

        //public static int guess;
        //public int count, min, max;



        //Random r = new Random();

        private void btnno_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        public void Frm14_guess_1_Load(object sender, EventArgs e)
        {

           btnok.Enabled = true;
            txtgu.Text = "";

        }

        

        private void btnok_Click(object sender, EventArgs e)
        {
            int myguess = 0;
            Frm14_guess form1 = (Frm14_guess)this.Owner;

            if (int.TryParse(txtgu.Text,out myguess))
            {
                if(myguess>=1 && myguess < 100)
                {
                    if (myguess == Frm14_guess.guess)
                    {
                        MessageBox.Show("Congratulations! You got " + Frm14_guess.guess);        
                        btnok.Enabled = false;
                    }

                    else if(myguess > Frm14_guess.guess)
                    {
                        Frm14_guess.max = myguess;
                        foreach (Form f in Application.OpenForms)
                        {

                            if (f.GetType() == typeof(Frm14_guess))
                                (f as Frm14_guess).SetLabelTest2($"Too small!");
                        }

                        foreach (Form f in Application.OpenForms)
                        {

                            if (f.GetType() == typeof(Frm14_guess))
                                (f as Frm14_guess).SetLabelTest($"{Frm14_guess.min} <  ?  < {Frm14_guess.max} ");
                        }
                        txtgu.Text = "";
                    }

                    else if (myguess < Frm14_guess.guess)
                    {
                        Frm14_guess.min = myguess;
                        foreach (Form f in Application.OpenForms)
                        {

                            if (f.GetType() == typeof(Frm14_guess))
                                (f as Frm14_guess).SetLabelTest2($"Too Large!");
                        }
                        foreach (Form f in Application.OpenForms)
                        {

                            if (f.GetType() == typeof(Frm14_guess))
                                (f as Frm14_guess).SetLabelTest($"{Frm14_guess.min} <  ?  < {Frm14_guess.max} ");
                        }
                        txtgu.Text = "";
                    }
            }
                else
                {
                    MessageBox.Show("請輸入提示範圍內的數字");
                }

                }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }
    }
}
