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
    public partial class Frm05_studentlist : Form
    {
        public Frm05_studentlist()
        {
            InitializeComponent();
        }

        string result;


        private void button2_Click(object sender, EventArgs e)
        {
            score sco;
            sco.studentname = txtN.Text;
            sco.scorechi = int.Parse(txtC.Text);
            sco.scoreeng = int.Parse(txte.Text);
            sco.scoremat = int.Parse(txtma.Text);
            sco.scoreto = sco.scorechi + sco.scoreeng + sco.scoremat;
            sco.scoreav = Math.Round((sco.scoreto / 3), 2, MidpointRounding.AwayFromZero);

            int[] sc = {Convert.ToInt32( sco.scorechi), Convert.ToInt32(sco.scoreeng), Convert.ToInt32(sco.scoremat) };
            string[] su = { "國文", "英文", "數學" };
            int maxScoreIndex = sc.ToList().IndexOf(sc.Max());
            int minScoreIndex = sc.ToList().IndexOf(sc.Min());

            result = $"{sco.studentname.PadRight(5)}{sco.scorechi.ToString().PadLeft(5)}{sco.scoreeng.ToString().PadLeft(8)}{sco.scoremat.ToString().PadLeft(11)}{sco.scoreto.ToString().PadLeft(14)}{ sco.scoreav.ToString().PadLeft(17)}{su[minScoreIndex]}{sc.Min().ToString().PadLeft(20)}{su[maxScoreIndex]}{sc.Max().ToString().PadLeft(23)}";


            labuser.Text = result;
        }

       
    }
}
