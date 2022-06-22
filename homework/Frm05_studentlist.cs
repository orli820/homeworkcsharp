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
            sco.scorechi = decimal.Parse(txtC.Text);
            sco.scoreeng = decimal.Parse(txte.Text);
            sco.scoremat = decimal.Parse(txtma.Text);
            sco.scoreto = sco.scorechi + sco.scoreeng + sco.scoremat;
            sco.scoreav = Math.Round((sco.scoreto / 3), 2, MidpointRounding.AwayFromZero);

            int[] sc = {Convert.ToInt32( sco.scorechi), Convert.ToInt32(sco.scoreeng), Convert.ToInt32(sco.scoremat) };
            string[] su = { "國文", "英文", "數學" };
            int maxScoreIndex = sc.ToList().IndexOf(sc.Max());
            int minScoreIndex = sc.ToList().IndexOf(sc.Min());

            result = $"{sco.studentname,-10}"+$"{sco.scorechi,4}"+$"{sco.scoreeng,9}"+$"{sco.scoremat,10}"+ $"{sco.scoreto,11}"+ $"{ sco.scoreav,11}" + $"{ su[minScoreIndex]}{sc.Min()}" + $"{ su[maxScoreIndex]}{sc.Max()}";


            labuser.Text = result;
        }

       
    }
}
