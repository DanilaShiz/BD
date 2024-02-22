using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }
        Bitmap bm;
        Graphics g;
        bool Paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen Lastik = new Pen(Color.White, 10);
        int index;

        int x, y, sX, sY, cX, cY;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Paint)
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                else if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(Lastik, px, py);
                    py = px;
                }
            pictureBox1.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(index == 7)
            {
                Point point = set_point(pictureBox1, e.Location);
               // Fill(bm, point.X, point.Y, new_color);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                bm.Save(saveFileDialog1.FileName);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            p = new Pen(p.Color, trackBar1.Value);
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 3)
                g.DrawEllipse(p, cX, cY, sX, sY);
            else if (index == 4)
                g.DrawRectangle(p, cX, cY, sX, sY);
            else if (index == 5)
                g.DrawLine(p, cX, cY, x, y);
        }

        private void pen_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void lastik_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void kvadrat_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void kryg_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (Paint)
                if (index == 3)
                    g.DrawEllipse(p, cX, cY, sX, sY);
                else if (index == 4)
                    g.DrawRectangle(p, cX, cY, sX, sY);
                else if (index == 5)
                    g.DrawLine(p, cX, cY, x, y);
        }

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                bm = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = bm;
            }
        }
    }
}
