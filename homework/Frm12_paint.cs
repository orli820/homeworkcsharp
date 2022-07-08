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
    public partial class Frm12_paint : Form
    {
        Graphics g;  //定義一個板
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;  //定義一枝筆
        private object colorDialog1;

        public Frm12_paint()
        {
            InitializeComponent();

            g = panel1.CreateGraphics();  //抓一個板
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //讓畫筆更順
            pen = new Pen(Color.Black, 1);  //拿一支筆
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;  //to starting and ending the line by round
            label1.Text = "";
        }

        private void Frm12_paint_load(object sender, MouseEventArgs e)
        {
            trackBar1.Minimum = 1;
            trackBar1.Maximum= 80;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 1;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            x = e.X;
            y = e.Y;
            panel1.Cursor = Cursors.Cross;            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            pen = new Pen(cd2.Color, trackBar1.Value);
            if (moving && x!=-1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);  //使用畫筆設定畫筆
                x = e.X;       //e是上面那個e
                y = e.Y;

                //pen = new Pen(cd2.Color, int.Parse(label1.Text));
                //pb1.Refresh();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = -1;
            y = -1;
            panel1.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cd2.ShowDialog() == DialogResult.OK)
            {
                pb1.BackColor = cd2.Color;


            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();           
        }       
    }
}
