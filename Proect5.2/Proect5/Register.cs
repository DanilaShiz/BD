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

namespace Proect5
{
    public partial class Register : Form
    {
        int chet;
        int l;

        public Register()
        {
            InitializeComponent();
            enterPas.UseSystemPasswordChar = true;
            enterPas2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e) //Вернуться на рабочий стол
        {
            Form1 WT = new Form1();
            WT.Show();
            Hide();
        }

        private void RegB_Click(object sender, EventArgs e)//Регистрация пользователя
        {
            chet = 0;
            if (enterLog.Text == "")//Проверка на пустые бланки
            {
                MessageBox.Show("Введите логин");
            }
            else if (enterPas.Text == "")//Проверка на пустые бланки
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                ProvNal();
                ProvPas();
                StreamWriter l1 = new StreamWriter(@"LoginUser.txt", true);
                StreamWriter p1 = new StreamWriter(@"PasswordUser.txt", true);

                    if (chet == 6 && l != 1)
                    {
                        if (enterPas.Text.Length >= 6)//Длинна пароля не меньше 6 символов
                        {
                            if (enterPas.Text == enterPas2.Text)//Совпадение паролей
                            {
                                l1.WriteLine(enterLog.Text+" 1");
                                p1.WriteLine(enterPas.Text);
                                MessageBox.Show("Вы зарегестрировались");
                                Hide();
                                Form1 WT = new Form1();
                                WT.Show();
                                enterLog.Clear();
                                enterPas.Clear();
                                enterPas2.Clear();
                            }
                            else //Пароли не савподают
                            {
                                MessageBox.Show("Проверьте пароли");
                                enterPas2.Clear();
                            }
                        }
                        else
                            MessageBox.Show("У вас слишком маленький:" + "\r\n" + "Пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
                l1.Close();
                p1.Close();
            }
        }

        private void ProvNal()//Проверка на занятость Логина
        {
            string cl;
            l = 0;
            StreamReader l0 = new StreamReader(@"LoginUser.txt", true);
            while ((!l0.EndOfStream) | (l == 1))
            {
                cl = l0.ReadLine();
                if (enterLog.Text == cl)
                {
                    l = 1;
                    DialogResult result = MessageBox.Show("Логин занят, попроуйте другой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    goto Vxod;
                    enterLog.Clear();
                    enterPas.Clear();
                    enterPas2.Clear();
                }
            }
            Vxod:
            l0.Close();
        }

        private void ProvPas()//Проверка Наналичие запрещенных симвалов
        {
            if (enterPas.Text.Contains(':') ^ enterLog.Text.Contains(':'))
            {
                DialogResult result = MessageBox.Show("символ ':' не допустим при регистрации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Simvols(@"[а-я]", enterLog.Text);
                Simvols(@"[а-я]", enterPas.Text);
                Simvols(@"[А-Я]", enterLog.Text);
                Simvols(@"[А-Я]", enterPas.Text);
                Simvols(@"\W", enterLog.Text);
                Simvols(@"\W", enterPas.Text);
            }
        }
        private void Simvols(string a, string b)
        {
            Regex regex = new Regex(a);
            MatchCollection matches = regex.Matches(b);//Проверка Наналичие запрещенных симвалов ч.2
            if (matches.Count > 0)
            {
                DialogResult result = MessageBox.Show("В полях допустимо:" + "\r\n" + "Латинские буквы и цифры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                chet = chet + 1;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            if (dostup.prava == 2)
                NA.Enabled = true;
            else
                NA.Enabled = false;
        }

        private void NA_Click(object sender, EventArgs e)
        {
            chet = 0;
            if (enterLog.Text == "")//Проверка на пустые бланки
            {
                MessageBox.Show("Введите логин");
            }
            else if (enterPas.Text == "")//Проверка на пустые бланки
            {
                MessageBox.Show("Введите пароль");
            }
            else
            {
                ProvNal();
                ProvPas();
                StreamWriter l1 = new StreamWriter(@"LoginUser.txt", true);
                StreamWriter p1 = new StreamWriter(@"PasswordUser.txt", true);
                if (chet == 6 && l != 1)
                {
                    if (enterPas.Text.Length >= 6)//Длинна пароля не меньше 6 символов
                    {
                        if (enterPas.Text == enterPas2.Text)//Совпадение паролей
                        {
                            l1.WriteLine(enterLog.Text+" 2");
                            p1.WriteLine(enterPas.Text);
                            MessageBox.Show("Вы зарегестрировались");
                            Hide();
                            Form1 WT = new Form1();
                            WT.Show();
                            enterLog.Clear();
                            enterPas.Clear();
                            enterPas2.Clear();
                        }
                        else //Пароли не савподают
                        {
                            MessageBox.Show("Проверьте пароли");
                            enterPas2.Clear();
                        }
                    }
                    else
                        MessageBox.Show("У вас слишком маленький:" + "\r\n" + "Пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                l1.Close();
                p1.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                enterPas.UseSystemPasswordChar = false;
            else
                enterPas.UseSystemPasswordChar = true;
        }
    }
}
