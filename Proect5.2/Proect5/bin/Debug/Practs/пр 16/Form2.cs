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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Text File(*.txt)|*.txt";
        }
        internal void Save()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox2.Text);
            MessageBox.Show("Сохранено!");
        }
        internal void Open()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string filetext = File.ReadAllText(filename);
            richTextBox2.Text = filetext;
        }
        internal void Copy()
        {
            richTextBox2.Copy();
        }
        internal void Cut()
        {
            richTextBox2.Cut();
        }

        internal void Paste()
        {
            richTextBox2.Paste();
        }

        internal void SelectAll()
        {
            richTextBox2.SelectAll();
        }

        internal void BackColor1()
        {
            colorDialog1.ShowDialog();
            richTextBox2.BackColor = colorDialog1.Color;
        }

        internal void ForeColor1()
        {
            colorDialog1.ShowDialog();
            richTextBox2.ForeColor = colorDialog1.Color;
        }
    }
}
