using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.IO;
using System.Collections;

namespace JelL_0._1
{
    public partial class Auth_form : Form
    {
        public int v;
        public Auth_form()
        {
        InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Вы пропустили какое-либо поле, пожалуйста введите значения во все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Auth_us();
            }
            /*string connetionString = null;
            MySqlConnection cnn;
            

            connetionString = "Server=192.168.56.1;port=3306;Database=IKIN;User Id=nikita;password=951753";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! "+ex);
            }*/


            //Hide();
            //Home h1 = new Home();
            //h1.Show();
        }
        private void Auth_form_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Users". При необходимости она может быть перемещена или удалена.
            //this.usersTableAdapter.Fill(this.databaseDataSet.Users);


        }

        private void Auth_form_FormClosing(object sender, EventArgs e)
        {
            Hide();
            Home h1 = new Home();
            h1.Show();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
        public int che = 0;
        public void Auth_us()
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
                    //string b = cash[1];
                    //int a = b.IndexOf(' ');
                    //if (a != -1)
                    //{
                        if (textBox1.Text == cash[0] && textBox2.Text == cash[1].Replace(" ", ""))
                        {
                            che = 1;
                            goto Vxod;
                            
                        }
                    //}
                }
            }

            Vxod:
            objReader.Close();
            if (che == 1)
            {
                DialogResult result = MessageBox.Show("Вы успешно вошли (нет)","Здравствуйте", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Home h1 = new Home();
                h1.Show();
                
            }
            else
            {
                DialogResult result = MessageBox.Show("Неправильный пароль или логин!!" + "\r\n" + "Зарегистрировать нового пользователя?","Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    Hide();
                    Reg r1 = new Reg();
                    r1.Show();
                }
            }
            {

            }
            //foreach (string sOutput in arrText)
            //textBox1.Text = sOutput;
        }

        private void Connect()
        {
            string connetionString = null;
            connetionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = ...\\Database.mdf\"; Integrated Security = True";
            SqlConnection cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать в программу, вы сейчас находитесь под учётной записью Гостя" + "\r\n" + "Чтобы войти под своей учётной записью или зарегестрировать новую, справа сверху для вас есть вход", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            Home h1 = new Home();
            h1.Show();
        }
    }
}











































//©Назаров Максим, Голиков Дмтирий, Беликов Андрей 3ПКС11-4