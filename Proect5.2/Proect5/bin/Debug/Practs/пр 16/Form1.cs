using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace пр_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 childForm = new Form2();
            childForm.MdiParent = this;
            childForm.Show();

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = ActiveMdiChild as Form2;
            form2.Open();
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = ActiveMdiChild as Form2;
            form2.ForeColor1();
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = ActiveMdiChild as Form2;
            form2.BackColor1();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = ActiveMdiChild as Form2;
            form2.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = ActiveMdiChild as Form2;
            form2.Paste();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = ActiveMdiChild as Form2;
            form2.Cut();
        }

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = ActiveMdiChild as Form2;
            form2.SelectAll();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = ActiveMdiChild as Form2;
            form2.Save();
        }
    }
}
