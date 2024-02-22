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
using System.Collections;

namespace JelL_0._1
{
    public partial class Home : Form
    {
        public int l;
        public Home()
        {       
            InitializeComponent();
    }
        private void User_Click(object sender, EventArgs e)
            {
            Auth_form a = new Auth_form();
            /*  if (a.v == 1)
              {
                  l = 1;
                  File.Enabled = true;
                  правкаToolStripMenuItem.Enabled = true;
                  видToolStripMenuItem.Enabled = true;
              }
              else
              {
                  l = 0;
                  File.Enabled = false;
                  правкаToolStripMenuItem.Enabled = false;
                  видToolStripMenuItem.Enabled = false;
              }*/
        }
        private void Home_Load(object sender, EventArgs e)
        {
          Auth_form a = new Auth_form();
            if (a.che == 1)
            {
                    File.Enabled = true;
                    правкаToolStripMenuItem.Enabled = true;
                    видToolStripMenuItem.Enabled = true;

            }
            else
            {
                File.Enabled = false;
                правкаToolStripMenuItem.Enabled = false;
                видToolStripMenuItem.Enabled = false;
            }
        }
        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auth_form a1 = new Auth_form();
            //a1.MdiParent = this;
            a1.Show();
            Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void тестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader objReader = new StreamReader("...\\auth_us.txt");
            string sLine = "";
            ArrayList arrText = new ArrayList();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                {
                    arrText.Add(sLine);
                    string[] sCh = { ":" };
                   
                }
            }
            objReader.Close();
            foreach (string sOutput in arrText)
                textBox1.Text = sOutput;
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reg rg1 = new Reg();
            rg1.Show();
            Hide();
        }

        private void кодСимволаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text.IndexOf(' ') != 1)
            //{
            int a = textBox1.Text.IndexOf(' ');
                Console.WriteLine(a);
            //}
        }
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Auth_form a = new Auth_form();
            MessageBox.Show("Вы успешно вышли из пользователя", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //a.l = 0;
            MessageBox.Show("Добро пожаловать в программу, вы сейчас находитесь под учётной записью Гостя" + "\r\n" + "Чтобы войти под своей учётной записью или зарегестрировать новую, справа сверху для вас есть вход", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуйте, вы запустили программу с применением баз данных (нет), над которой кропотливо трудился Голиков Д.А.:", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void File_Click(object sender, EventArgs e)
        {

        }
}
}
