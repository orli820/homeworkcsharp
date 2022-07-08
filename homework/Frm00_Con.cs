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




        private void button1_Click_1(object sender, EventArgs e)
        {
            //fm2.Visible = false;
            //fm3.Visible = false;
            //fm4.Visible = false;
            //fm5.Visible = false;
            //fm8.Visible = false;
            //fm9.Visible = false;
            //fm14.Visible = false;


            //hll.Visible = true;
            Frm_Hello hll = new Frm_Hello();
            hll.TopLevel = false;
            hll.Parent = this.splitContainer2.Panel2;
            hll.Show();      

            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm_Hello) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();                    
                    return;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //fm2.Visible = true;

            //hll.Visible = false;
            //fm3.Visible = false;
            //fm4.Visible = false;            
            //fm5.Visible = false;
            //fm8.Visible = false;
            //fm9.Visible = false;
            //fm14.Visible = false;

            Frm02_loan fm2 = new Frm02_loan();
            fm2.TopLevel = false;
            fm2.Parent = this.splitContainer2.Panel2;
            fm2.Show();
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() != typeof(Frm02_loan) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    //return;
                    //this.splitContainer2.Panel2.Controls.Clear();
                    return;
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {


            //fm3.Show();

            //hll.Visible = false;
            //fm2.Visible = false;
            //fm4.Visible = false;
            //fm5.Visible = false;
            //fm8.Visible = false;
            //fm9.Visible = false;
            //fm14.Visible = false;

            Frm03_menu fm3 = new Frm03_menu();
            fm3.TopLevel = false;
            fm3.Parent = this.splitContainer2.Panel2;
            fm3.Show();
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm03_menu) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {


            //fm4.Show();


            //hll.Visible = false;
            //fm2.Visible = false;
            //fm3.Visible = false;
            //fm5.Visible = false;
            //fm8.Visible = false;
            //fm9.Visible = false;
            //fm14.Visible = false;

            Frm04_scrip fm4 = new Frm04_scrip();
            fm4.TopLevel = false;
            fm4.Parent = this.splitContainer2.Panel2;
            fm4.Show();
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm04_scrip) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //fm14.Show();

            //hll.Visible = false;
            //fm2.Visible = false;
            //fm3.Visible = false;
            //fm4.Visible = false;
            //fm5.Visible = false;
            //fm8.Visible = false;
            //fm9.Visible = false;
            Frm14_guess fm14 = new Frm14_guess();
            fm14.TopLevel = false;
            fm14.Parent = this.splitContainer2.Panel2;
            fm14.Show();
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm14_guess) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            //fm5.Show();

            //hll.Visible = false;
            //fm2.Visible = false;
            //fm3.Visible = false;
            //fm4.Visible = false;
            //fm8.Visible = false;
            //fm9.Visible = false;
            //fm14.Visible = false;

            Frm05_studentlist fm5 = new Frm05_studentlist();
            fm5.TopLevel = false;
            fm5.Parent = this.splitContainer2.Panel2;
            fm5.Show();
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm05_studentlist) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }
            }



        }
        private void button6_Click(object sender, EventArgs e)
        {

            //fm8.Show();

            //hll.Visible = false;
            //fm2.Visible = false;
            //fm3.Visible = false;
            //fm4.Visible = false;
            //fm5.Visible = false;
            //fm9.Visible = false;
            //fm14.Visible = false;

            Frm08_cla fm8 = new Frm08_cla();
            fm8.TopLevel = false;
            fm8.Parent = this.splitContainer2.Panel2;
            fm8.Show();
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm08_cla) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            //fm9.Show();

            //hll.Visible = false;
            //fm2.Visible = false;
            //fm3.Visible = false;
            //fm4.Visible = false;
            //fm8.TopLevel = false;
            //fm8.Parent = this.splitContainer2.Panel2;
            //fm8.Show();

            //hll.Visible = false;
            //fm2.Visible = false;
            //fm3.Visible = false;
            //fm4.Visible = false;
            //fm5.Visible = false;
            //fm8.Visible = false;
            //fm14.Visible = false;

            FrmOX fm9 = new FrmOX();
            fm9.TopLevel = false;
            fm9.Parent = this.splitContainer2.Panel2;
            fm9.Show();           
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(FrmOX) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Frm12_paint fm12 = new Frm12_paint();
            fm12.TopLevel = false;
            fm12.Parent = this.splitContainer2.Panel2;
            fm12.Show();
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm12_paint) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Frm15_clo fm15 = new Frm15_clo();
            fm15.TopLevel = false;
            fm15.Parent = this.splitContainer2.Panel2;
            fm15.Show();
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm15_clo) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Frmpad fm16 = new Frmpad();
            fm16.TopLevel = false;
            fm16.Parent = this.splitContainer2.Panel2;
            fm16.Show();

            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frmpad) && f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }
            }
        }
    }
}
