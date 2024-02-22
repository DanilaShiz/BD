using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JelL_0._1
{
    public partial class Reg : Form
    {
        int chet;
        int che;
        public Reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chet = 0;
            Proverka();
            Read();
            if (chet == 6 && che != 1)
            {
                Zap();
                DialogResult result = MessageBox.Show("Регистрация прошла успешно!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Home h1 = new Home();
                h1.Show();
                Hide();
            }
           else
            {
                DialogResult result = MessageBox.Show("Интересно, оно выдаст это сообщение", "?", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void Read()
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
                    char[] sCh = { ':' };
                    string[] cash = sLine.Split(sCh);
                    if (textBox1.Text == cash[0])
                    {
                        che = 1;
                        DialogResult result = MessageBox.Show("Логин занят, попроуйте другой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto Vxod;
                    }

                }
            }

        Vxod:
            objReader.Close();

        }

        private void Simvols(string a,string b)
        {
            Regex regex = new Regex(a);
            MatchCollection matches = regex.Matches(b);
            if (matches.Count > 0)
            {
                DialogResult result = MessageBox.Show("В полях допустимо:" + "\r\n" + "Латинские буквы и цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chet = chet + 1;
            }
        }
        
        private void Proverka()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (textBox2.Text.Contains(':') ^ textBox1.Text.Contains(':'))
                    {
                        DialogResult result = MessageBox.Show("символ ':' не допустим при регистрации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        Simvols(@"[а-я]", textBox1.Text);
                        Simvols(@"[а-я]", textBox2.Text);
                        Simvols(@"[А-Я]", textBox1.Text);
                        Simvols(@"[А-Я]", textBox2.Text);
                        Simvols(@"\W", textBox1.Text);
                        Simvols(@"\W", textBox2.Text);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Поля ввода пароля не свопадают!!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Какое то из полей не заполнено!!" + "\r\n" + "Просьба заполнить все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Zap()
        {
            
            using (StreamWriter sw = new StreamWriter("...\\auth_us.txt", true))
            {
                sw.WriteLine("\n" + textBox1.Text + ":" + textBox2.Text + ((char)160));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.Show();
            Hide();
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
