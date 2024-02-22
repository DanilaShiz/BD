using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proect5
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        
        private void button2_Click(object sender, EventArgs e)//Вернуться на рабочий стол
        {
            Form1 WT = new Form1();
            WT.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e) //Зайти за гостя
        {
            MessageBox.Show("Теперь ты Гость... Смирись с этим!" + "\r\n" + "Чтобы войти нужно зарегестрировать новую учетку, если вы уже зарегистрированы, так не будте гостем!!!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            Form1 WT = new Form1();
            WT.Show();
        }

        private void AutB_Click(object sender, EventArgs e)//Авторизация
        {
            //login = enterLog.Text;
            //Pass = enterPas.Text;
            int chekcol = 0;
            string cheklog;
            int soklog = 0;
            string chekpas;
            StreamReader l1 = new StreamReader(@"LoginUser.txt", true);
            StreamReader p1 = new StreamReader(@"PasswordUser.txt", true);
            string safelog = "";
            //Проверка на пустые бланки
            if (enterLog.Text == "" & enterPas.Text == "")
            {
                MessageBox.Show("Введите логин и пароль (1)");
            }
            else if (enterLog.Text == "")
            {
                MessageBox.Show("Введите логин");
            }
            else if (enterPas.Text == "")
            {
                MessageBox.Show("Введите пароль");
            }
            //------------------------------------------
            else
            {
                //------------------------------------------
                //Проверка диапаазона
                StreamReader l0 = new StreamReader(@"LoginUser.txt", true);
                while (!l0.EndOfStream)
                {
                    string x = l0.ReadLine();
                    chekcol++;
                }
                l0.Close();
                //------------------------------------------
                //Проверка на наличие в файлах человека и пароля (места Логина и пароля должны савподать в текст.файле)
                for (int i = 0; i < chekcol; i++)
                {
                    cheklog = l1.ReadLine();
                    chekpas = p1.ReadLine();
                    if ((enterLog.Text+" 2" == cheklog | enterLog.Text+" 1" == cheklog) && enterPas.Text == chekpas)
                    {
                        soklog = 1;
                        safelog = cheklog;
                    }
                }
                //------------------------------------------
                if (soklog == 1)// Вход
                {
                    
                    MessageBox.Show("Добро пожаловать!");
                    Hide();
                    Form1 WT = new Form1();
                    if (safelog == enterLog.Text + " 2") //Значение прав пользователя
                        dostup.prava = 2;
                    else
                        dostup.prava = 1;
                    safelog = "";
                    WT.Show();
                }
                else
                {
                    soklog = 0;
                    MessageBox.Show("Неверный логин, или пароль (2)");
                }
                //------------------------------------------
            }
            l1.Close();
            p1.Close();
            enterLog.Clear();
            enterPas.Clear();
            
        }

    }
    public static class dostup
    {
        static public int prava = 0; // Значение прав по умолчанию
    }
}
