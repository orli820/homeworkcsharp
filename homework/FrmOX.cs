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
    public partial class FrmOX : Form
    {
        bool turn = true;  //true= X turn, false= Y turn
        int turn_count = 0;

        

        public FrmOX()
        {
            InitializeComponent();
        }

        private void btnex_Click(object sender, EventArgs e)   //close
        {
           foreach (Form f in Application.OpenForms)
            {

                if ( f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;   //設置不能反覆點擊
            //btnex.Enabled = true;
           //btnre.Enabled = true;            
            turn_count++;
            checkForWinner();
        }

        private void checkForWinner()        //win role
        {
            bool there_is_a_wiinner = false;

            if((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_a_wiinner = true;
            else if ((A4.Text == A5.Text) && (A5.Text == A6.Text) && (!A4.Enabled))
                there_is_a_wiinner = true;
            else if ((A7.Text == A8.Text) && (A8.Text == A9.Text) && (!A7.Enabled))
                there_is_a_wiinner = true;
            else if ((A1.Text == A5.Text) && (A5.Text == A9.Text) && (!A1.Enabled))
                there_is_a_wiinner = true;
            else if ((A3.Text == A5.Text) && (A5.Text == A7.Text) && (!A3.Enabled))
                there_is_a_wiinner = true;
            if ((A1.Text == A4.Text) && (A4.Text == A7.Text) && (!A1.Enabled))
                there_is_a_wiinner = true;
            else if ((A2.Text == A5.Text) && (A5.Text == A8.Text) && (!A2.Enabled))
                there_is_a_wiinner = true;
            else if ((A3.Text == A6.Text) && (A6.Text == A9.Text) && (!A3.Enabled))
                there_is_a_wiinner = true;

            if (there_is_a_wiinner)    //winner's message
            {
                disablebuttons();
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + "  Wins!", "Ohhh");
            }
            else
            {
                if (turn_count==9)
                    MessageBox.Show("No one  Wins!", "Ahhh");
            }    
        }

        private void disablebuttons()
        {
            try
            {
                foreach(Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                    btnex.Enabled = true;
                    btnre.Enabled = true;
                }               
            }
            catch { }
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;
            try
            {
                foreach (Component c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    btnex.Text= "exit";
                    btnre.Text = "reset";
                }
            }
            catch { }
        }
    }
}
