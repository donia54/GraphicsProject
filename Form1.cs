using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secAss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Drow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            pictureBox1.Image = null;
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            int x1 = int.Parse(txt_x1.Text);
            int x2 = int.Parse(txt_x2.Text);
            int y1 = int.Parse(txt_y1.Text);
            int y2 = int.Parse(txt_y2.Text);
            int dx = x2 - x1;
            int dy = y2 - y1;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            double x_inc = dx /(double) steps;
            double y_inc = dy /(double)steps;
            double x = x1;
            double y = y1;
            for (int i = 0; i <= steps; i++)
            {
                dataGridView1.Rows.Add(i,x, y,Math.Round(x,0),Math.Round(y,0));
                bmp.SetPixel((int) x,(int) y, Color.Black);
                x +=x_inc;
                y += y_inc;
            }

            pictureBox1.Image = bmp;
        }
    }
}
