using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Frmpad : Form
    {
        public Frmpad()
        {
            InitializeComponent();
                     
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Alex", "About");
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {

                if (f.GetType() != typeof(Frm00_Con))
                {
                    f.Close();
                    return;
                }

            }
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"E:\資策會\C#\homeworkcsharp\homework\obj\note.txt", Encoding.UTF8);
            textBox1.Text = sr.ReadToEnd();
            sr.Close();

        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("newtext.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(textBox1.Text);
            sw.Close();
            fs.Close();
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = colorDialog1.Color;


            }
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
