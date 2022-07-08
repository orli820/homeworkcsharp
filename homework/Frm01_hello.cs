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
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();

          
           
        }

        

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            string Name = txt_Name.Text;
            string Birth =txt_Birth.Text;

            Gender Sex;
            if(cmb_Sex.Text=="male")
            {
                Sex = male;
            }
            else
            {
                Sex = female;
            }
            string result = (cmb_Sex.Text);

            string Star = txt_Star.Text;

            MessageBox.Show("Hello,我是" + Name+Environment.NewLine +"生日是"+ Birth+Environment.NewLine+"性別是"+ result+Environment.NewLine+"星座是" +Star + Environment.NewLine+ "很高興認識你!");

                    }

        delegate string Gender(string sex);

        string male(string sex)
        {
            return "male";
        }
        string female(string sex)
        {
            return "female";
        }

        private void btn_Hi_Click(object sender, EventArgs e)
        {
            string Name = txt_Name.Text;
            string Birth = txt_Birth.Text;

            Gender Sex;
            if (cmb_Sex.Text == "male")
            {
                Sex = male;
            }
            else
            {
                Sex = female;
            }
            string result = (cmb_Sex.Text);

            string Star = txt_Star.Text;

            MessageBox.Show("Hi,我是" + Name + Environment.NewLine + "生日是" + Birth + Environment.NewLine + "性別是" + result + Environment.NewLine + "星座是" + Star + Environment.NewLine + "剛剛不是已經打招呼過了嗎?");

        }

      
    }
}
