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
    public partial class Frm08_cla : Form
    {
        public Frm08_cla()
        {
            InitializeComponent();
        }

        cal mycal;
        caladd add = new caladd();
        calred red = new calred();
        calmul mul = new calmul();
        caldiv div = new caldiv();


        double QOO = 0;
        double QOOO = 0;


       

        public void button1_Click(object sender, EventArgs e)
        {

            caladd count = new caladd();  //不能用cal,因為cal是抽象的框架要用被繼承的(實體)來實作
            if (double.TryParse(txtx.Text, out QOO))
            {

                count.x = Convert.ToDouble(QOO);

            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txtx.Text = "";
                txtx.Focus();
                return;
            }

            if (double.TryParse(txty.Text, out QOOO))
            {
                count.y = Convert.ToDouble(QOOO);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txty.Text = "";
                txty.Focus();
                return;
            }

            mycal = add;
            mycal.x = double.Parse(txtx.Text);
            mycal.y = double.Parse(txty.Text);
            laban.Text = mycal.answer().ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            caladd count = new caladd();
            if (double.TryParse(txtx.Text, out QOO))
            {

                count.x = Convert.ToDouble(QOO);

            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txtx.Text = "";
                txtx.Focus();
                return;
            }

            if (double.TryParse(txty.Text, out QOOO))
            {
                count.y = Convert.ToDouble(QOOO);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txty.Text = "";
                txty.Focus();
                return;
            }

            mycal = red;
            mycal.x = double.Parse(txtx.Text);
            mycal.y = double.Parse(txty.Text);
            laban.Text = mycal.answer().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            caladd count = new caladd();  
            if (double.TryParse(txtx.Text, out QOO))
            {

                count.x = Convert.ToDouble(QOO);

            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txtx.Text = "";
                txtx.Focus();
                return;
            }

            if (double.TryParse(txty.Text, out QOOO))
            {
                count.y = Convert.ToDouble(QOOO);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txty.Text = "";
                txty.Focus();
                return;
            }

            mycal = mul;
            mycal.x = double.Parse(txtx.Text);
            mycal.y = double.Parse(txty.Text);
            laban.Text = mycal.answer().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            caladd count = new caladd();
            if (double.TryParse(txtx.Text, out QOO))
            {

                count.x = Convert.ToDouble(QOO);

            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txtx.Text = "";
                txtx.Focus();
                return;
            }

            if (double.TryParse(txty.Text, out QOOO))
            {
                count.y = Convert.ToDouble(QOOO);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txty.Text = "";
                txty.Focus();
                return;
            }

            mycal = div;
            mycal.x = double.Parse(txtx.Text);
            mycal.y = double.Parse(txty.Text);
            laban.Text = mycal.answer().ToString();
        }
    }
}
