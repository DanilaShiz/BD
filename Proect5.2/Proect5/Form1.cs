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

namespace Proect5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void входToolStripMenuItem1_Click(object sender, EventArgs e)//Авторизация
        {
            Login Log = new Login();
            Log.Show();
            Hide();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)//Регистрация
        {
            Register Reg = new Register();
            Reg.Show();
            Hide();
        }

        private void CloseB_Click_1(object sender, EventArgs e)//Закрыть программу
        {
            Application.Exit();

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)//Выход из учетной записи
        {
            MessageBox.Show("Теперь ты Гость... Смирись с этим!" + "\r\n" + "Чтобы войти нужно зарегестрировать новую учетку, если вы уже зарегистрированы, так не будте гостем!!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            dostup.prava = 0;
            Form1_Load_1(null, null);
        }

        private void Form1_Load_1(object sender, EventArgs e)//ПРАВА ДОСТУПА
        {
            if (dostup.prava == 1)
            {
                ExitGOST.Enabled = true;
                fpr.Enabled = true;
                pravka.Enabled = true;
                vid.Enabled = true;
                pr2.Enabled = true;
                pr3.Enabled = true;
                pr4.Enabled = true;
                pr5.Enabled = true;
                pr6.Enabled = true;
                pr7.Enabled = true;
                pr8.Enabled = true;
                pr9.Enabled = true;
                pr10.Enabled = true;
                pr11.Enabled = true;
                pr12.Enabled = false;
                pr13.Enabled = false;
                pr14.Enabled = false;
                pr15.Enabled = false;
                pr16.Enabled = false;
                pr17.Enabled = false;
                pr18.Enabled = false;
                pr19.Enabled = false;
                IndR.Enabled = false;
                VidForm.Enabled = true;

            }
            else if (dostup.prava == 0)
            {
                ExitGOST.Enabled = false;
                fpr.Enabled = false;
                pravka.Enabled = false;
                vid.Enabled = false;
                pr2.Enabled = false;
                pr3.Enabled = false;
                pr4.Enabled = false;
                pr5.Enabled = false;
                pr6.Enabled = false;
                pr7.Enabled = false;
                pr8.Enabled = false;
                pr9.Enabled = false;
                pr10.Enabled = false;
                pr11.Enabled = false;
                pr12.Enabled = false;
                pr13.Enabled = false;
                pr14.Enabled = false;
                pr15.Enabled = false;
                pr16.Enabled = false;
                pr17.Enabled = false;
                pr18.Enabled = false;
                pr19.Enabled = false;
                IndR.Enabled = false;
                VidForm.Enabled = false;
            }
            else if (dostup.prava == 2)
            {
                ExitGOST.Enabled = true;
                fpr.Enabled = true;
                pravka.Enabled = true;
                vid.Enabled = true;
                pr2.Enabled = true;
                pr3.Enabled = true;
                pr4.Enabled = true;
                pr5.Enabled = true;
                pr6.Enabled = true;
                pr7.Enabled = true;
                pr8.Enabled = true;
                pr9.Enabled = true;
                pr10.Enabled = true;
                pr11.Enabled = true;
                pr12.Enabled = true;
                pr13.Enabled = true;
                pr14.Enabled = true;
                pr15.Enabled = true;
                pr16.Enabled = true;
                pr17.Enabled = true;
                pr18.Enabled = true;
                pr19.Enabled = true;
                IndR.Enabled = true;
                VidForm.Enabled = true;
            }
        }

        private void пр2ToolStripMenuItem_Click(object sender, EventArgs e)//Открать пр2 (Там не она) :)
        {
            ToolStripMenuItem f = sender as ToolStripMenuItem;
            switch (f.Text)
            {
                case "пр 2-1":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 2-1\bin\Debug\netcoreapp3.1\пр 2-1.exe");
                    break;
                case "пр 2-2":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 2-2\bin\Debug\netcoreapp3.1\пр 2-2.exe");
                    break;
                case "пр 3-1":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 3-1\bin\Debug\netcoreapp3.1\пр 3-1.exe");
                    break;
                case "пр 3-2":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 3-2\bin\Debug\netcoreapp3.1\пр 3-2.exe");
                    break;
                case "пр 3-3":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 3-3\bin\Debug\netcoreapp3.1\пр 3-3.exe");
                    break;
                case "пр 4-1":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 4-1\bin\Debug\netcoreapp3.1\пр 4-1.exe");
                    break;
                case "пр 4-2":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 4-2\bin\Debug\netcoreapp3.1\пр 4-2.exe");
                    break;
                case "пр 5-1":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 5-1\bin\Debug\netcoreapp3.1\пр 5-1.exe");
                    break;
                case "пр 5-2":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 5-2\bin\Debug\netcoreapp3.1\пр 5-2.exe");
                    break;
                case "пр 6-1":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 6-1\bin\Debug\netcoreapp3.1\пр 6-1.exe");
                    break;
                case "пр 6-2":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 6-2\bin\Debug\netcoreapp3.1\пр 6-2.exe");
                    break;
                case "пр 6-3":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 6-3\bin\Debug\netcoreapp3.1\пр 6-3.exe");
                    break;
                case "пр 6-4":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 6-4\bin\Debug\netcoreapp3.1\пр 6-4.exe");
                    break;
                case "пр 7-1":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 7-1\bin\Debug\netcoreapp3.1\пр 7-1.exe");
                    break;
                case "пр 7-2":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 7-2\bin\Debug\netcoreapp3.1\пр 7-2.exe");
                    break;
                case "пр 7-3":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 7-3\bin\Debug\netcoreapp3.1\пр 7-3.exe");
                    break;
                case "пр 8-1":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 8-1\bin\Debug\netcoreapp3.1\пр 8-1.exe");
                    break;
                case "пр 8-2":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 8-2\bin\Debug\netcoreapp3.1\пр 8-2.exe");
                    break;
                case "пр 9-1":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 9-1\bin\Debug\netcoreapp3.1\пр 9-1.exe");
                    break;
                case "пр 9-2":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 9-2\bin\Debug\netcoreapp3.1\пр 9-2.exe");
                    break;
                case "пр 10":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 10\bin\Debug\netcoreapp3.1\пр 10.exe");
                    break;
                case "пр 11-1":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 11-1\bin\Debug\netcoreapp3.1\пр 11-1.exe");
                    break;
                case "пр 11-2":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 11-2\bin\Debug\netcoreapp3.1\пр 11-2.exe");
                    break;
                case "пр 12":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 12\bin\Debug\netcoreapp3.1\пр 12.exe");
                    break;
                case "пр 13":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 13\bin\Debug\netcoreapp3.1\пр 13.exe");
                    break;
                case "пр 14":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 14\bin\Debug\netcoreapp3.1\пр 14.exe");
                    break;
                case "пр 15":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\CALCULATORv2\bin\Debug\CALCULATORv2.exe");
                    break;
                case "пр 16":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 16\bin\Debug\пр 16.exe");
                    break;
                case "пр 17":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 17\bin\Debug\пр 17.exe");
                    break;
                case "пр 18":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\пр 18\bin\Debug\пр 18.exe");
                    break;
                case "Клиент":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\ПР 19\bin\Debug\пр 19.exe");
                    break;
                case "Сервер":
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\ПР 19.1\bin\Debug\пр 19.1.exe");
                    break;
                case "индивидуальная работа":
                    //MessageBox.Show("Данной работы пока нету");
                    System.Diagnostics.Process.Start(Environment.CurrentDirectory + @"\Practs\WhatTheHell\JelL 0.1\bin\Debug\JelL 0.1.exe");
                    break;
            }
        }
        private void свернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chek.f < 5)
            {
                Form zam = new Form();
                zam.MdiParent = this;
                int n = this.MdiChildren.Count();
                zam.Text = "Документ " + Convert.ToString(n);

                RichTextBox txz = new RichTextBox();
                zam.Controls.Add(txz);
                txz.Dock = DockStyle.Fill;
                zam.Show();

                chek.f++;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
                chek.f--;
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] zam = MdiChildren;
            foreach (Form i in zam)
            {
                i.Close();
                chek.f=0;
            }
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox txz = this.ActiveMdiChild.Controls[0] as RichTextBox;
            txz.Copy();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox txz = this.ActiveMdiChild.Controls[0] as RichTextBox;
            txz.Cut();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox txz = this.ActiveMdiChild.Controls[0] as RichTextBox;
            txz.Paste();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
                this.ActiveMdiChild.Font = fontDialog1.Font;
        }

        private void фонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox txz = this.ActiveMdiChild.Controls[0] as RichTextBox;
            colorDialog1.ShowDialog();
            txz.BackColor = colorDialog1.Color;
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox txz = this.ActiveMdiChild.Controls[0] as RichTextBox;
            colorDialog1.ShowDialog();
            txz.ForeColor = colorDialog1.Color;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox txz = this.ActiveMdiChild.Controls[0] as RichTextBox;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string filetext = File.ReadAllText(filename);
            txz.Text = filetext;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox txz = this.ActiveMdiChild.Controls[0] as RichTextBox;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, txz.Text);
            MessageBox.Show("Сохранено!");
        }

        private void saveWhatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static class chek
        {
            static public int f = 0; 
        }
    }
}
