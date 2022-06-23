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

        public int guess, count, min, max;



        Random r = new Random();

        private void btnno_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Frm14_guess_1_Load(object sender, EventArgs e)
        {
           
            guess = r.Next(1, 100); //隨機數字是guess
            min = 0;
            max = 100;
            btnok.Enabled = true;
            txtgu.Text = "";

        }

        Frm14_guess frm14 = new Frm14_guess();

        private void btnok_Click(object sender, EventArgs e)
        {
            int myguess = 0;
            if (int.TryParse(txtgu.Text,out myguess))
            {
                if(myguess>=1 && myguess < 100)
                {
                    if (myguess == guess)
                    {
                        MessageBox.Show("Congratulations! You got " + guess);        
                        btnok.Enabled = false;
                    }

                    else if(myguess > guess)
                    {
                        max = myguess;
                        foreach (Form f in Application.OpenForms)
                        {

                            if (f.GetType() == typeof(Frm14_guess))
                                (f as Frm14_guess).SetLabelTest2($"Too small!");
                        }

                        foreach (Form f in Application.OpenForms)
                        {

                            if (f.GetType() == typeof(Frm14_guess))
                                (f as Frm14_guess).SetLabelTest($"{min} <  ?  < {max} ");
                        }
                        txtgu.Text = "";
                    }

                    else if (myguess < guess)
                    {
                        min = myguess;
                        foreach (Form f in Application.OpenForms)
                        {

                            if (f.GetType() == typeof(Frm14_guess))
                                (f as Frm14_guess).SetLabelTest2($"Too Large!");
                        }
                        foreach (Form f in Application.OpenForms)
                        {

                            if (f.GetType() == typeof(Frm14_guess))
                                (f as Frm14_guess).SetLabelTest($"{min} <  ?  < {max} ");
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
