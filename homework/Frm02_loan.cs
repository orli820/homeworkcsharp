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
    public partial class Frm02_loan : Form
    {
        public Frm02_loan()
        {
            InitializeComponent();

        }

        double LOOO = 0;
        


        public void btn_Month_Click(object sender, EventArgs e)
        {
            Loo loo;
            if (double.TryParse(txt_loan.Text, out LOOO))
            {
                loo.loanM = Convert.ToDouble(txt_loan.Text);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txt_loan.Text = "";
                txt_loan.Focus();
                return;
            }
            if (double.TryParse(txt_year.Text, out LOOO))
            {
                loo.yearM = Convert.ToDouble(txt_loan.Text);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txt_year.Text = "";
                txt_year.Focus();
                return;
            }
            if (double.TryParse(txt_rate.Text, out LOOO))
            {
                loo.RateM = Convert.ToDouble(txt_loan.Text);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txt_rate.Text = "";
                txt_rate.Focus();
                return;
            }
            if (double.TryParse(txt_dnpay.Text, out LOOO))
            {
                loo.dnpayM = Convert.ToDouble(txt_loan.Text);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txt_dnpay.Text = "";
                txt_dnpay.Focus();
                return;
            }
            
            MessageBox.Show("月付額" + PMT().ToString() + "元");

            
            
        }
        public void btn_Total_Click(object sender, EventArgs e)
        {
            Loo loo;
            if (double.TryParse(txt_loan.Text, out LOOO))
            {
                loo.loanM = Convert.ToDouble(txt_loan.Text);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txt_loan.Text = "";
                txt_loan.Focus();
                return;
            }
            if (double.TryParse(txt_year.Text, out LOOO))
            {
                loo.yearM = Convert.ToDouble(txt_loan.Text);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txt_year.Text = "";
                txt_year.Focus();
                return;
            }
            if (double.TryParse(txt_rate.Text, out LOOO))
            {
                loo.RateM = Convert.ToDouble(txt_loan.Text);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txt_rate.Text = "";
                txt_rate.Focus();
                return;
            }
            if (double.TryParse(txt_dnpay.Text, out LOOO))
            {
                loo.dnpayM = Convert.ToDouble(txt_loan.Text);
            }
            else
            {
                MessageBox.Show("請輸入正確的數字格式!!!!!");
                txt_dnpay.Text = "";
                txt_dnpay.Focus();
                return;
            }


            double R2 = Math.Round(PMT() * 12 * double.Parse(txt_year.Text));

            MessageBox.Show("總付額" + R2.ToString() + "元");
        }

        int PMT() 
        {
            
            double myMoney = double.Parse(txt_loan.Text); //貸款金額 
            double myYear = double.Parse(txt_year.Text);  //期限
            double myRate = double.Parse(txt_rate.Text);  //年利率
            double mydownpay = double.Parse(txt_dnpay.Text);      //頭期款

            double MR = myRate / 12 / 100;  //月利率
            double Y = myYear * 12;   //月數

            double cal1 = (Math.Pow(1 + MR, Y)) * MR / ((Math.Pow(1 + MR, Y)) - 1);
            //每月應還本息金額之平均攤還率
            int R1 =(int) Math.Round((myMoney - mydownpay) * cal1);
            //宣告R1是整數，貸款金額*每月應還本息金額之平均攤還率,double轉int            
            return R1;

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Frm02_report Report = new Frm02_report();
            Report.txt_reloan.Text = txt_loan.Text;
            Report.txt_reyear.Text = txt_year.Text;
            Report.txt_rerate.Text = txt_rate.Text;
            Report.txt_rednpay.Text = txt_dnpay.Text;
            Report.txt_reMP.Text = PMT().ToString();
            Report.txt_reT.Text = Math.Round(PMT() * 12 * double.Parse(txt_year.Text)).ToString();

            Report.Show();
            //呼叫report表單

                     

        }

       

    }
}
