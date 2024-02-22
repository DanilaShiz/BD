using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics gr = pictureBox1.CreateGraphics();
            Pen th = new Pen(Color.Black);
            gr.DrawEllipse(th, 86, 338, 104, 95);
            gr.FillEllipse(new SolidBrush(Color.DarkOliveGreen), 86, 338, 104, 95);
            gr.DrawRectangle(th, 123, 322, 27, 17);
            gr.FillRectangle(new SolidBrush(Color.DarkOliveGreen), 123, 322, 27, 17);
            gr.DrawLine(th, 136, 320, 136, 279);
            gr.DrawEllipse(th, 102, 216, 68, 60);
            gr.FillEllipse(new SolidBrush(Color.Purple), 102, 216, 68, 60);
            gr.DrawEllipse(th, 121, 187, 30, 28);//min
            gr.FillEllipse(new SolidBrush(Color.Yellow), 121, 187, 30, 28);
            gr.DrawEllipse(th, 150, 172, 68, 60);
            gr.FillEllipse(new SolidBrush(Color.Green), 150, 172, 68, 60);
            gr.DrawEllipse(th, 53, 172, 68, 60);
            gr.FillEllipse(new SolidBrush(Color.Blue), 53, 172, 68, 60);
            gr.DrawEllipse(th, 104, 126, 68, 60);
            gr.FillEllipse(new SolidBrush(Color.Red), 104, 126, 68, 60);
            gr.DrawEllipse(th, 152, 184, 38, 36);//Малые
            gr.FillEllipse(new SolidBrush(Color.PeachPuff), 152, 184, 38, 36);
            gr.DrawEllipse(th, 118, 150, 38, 36);
            gr.FillEllipse(new SolidBrush(Color.LightGreen), 118, 150, 38, 36);
            gr.DrawEllipse(th, 82, 185, 38, 36);
            gr.FillEllipse(new SolidBrush(Color.LightBlue), 82, 185, 38, 36);
            gr.DrawEllipse(th, 118, 217, 38, 36);
            gr.FillEllipse(new SolidBrush(Color.LightCoral), 118, 217, 38, 36);

        }
    }
}
