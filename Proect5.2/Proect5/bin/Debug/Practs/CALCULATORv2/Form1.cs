using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATORv2
{
    public partial class Form1 : Form
    {
        public string Numb1;
        public int x = 0;
        public string znak = "=";
        public string znak2;
        public Form1()
        {
            InitializeComponent();
        }
        // ----------------------------------------------------------------------------------
        private void button15_Click(object sender, EventArgs e)
        {
            if (x == 1) // Чекалка для написания следующего числа
            {
                x = 0;
                textBox1.Text = "";
            }
            Button numb1 = sender as Button;
            textBox1.Text = textBox1.Text + numb1.Text; // Ввод Числа
        }
        // ----------------------------------------------------------------------------------
        private void button10_Click(object sender, EventArgs e)
        {
            Button znk = sender as Button;
            znak = znk.Text;
            if (znk.Text == "+" | znk.Text == "-" | znk.Text == "*" | znk.Text == "/")
            {
                znak2 = znk.Text;
                Numb1 = textBox1.Text; //запомнить первое число
                x = 1; // для чекалки
            }
            else
            {
                switch (znk.Text)
                {
                    case "С":
                        textBox1.Text = " "; // Стерание
                        break;
                    case "+/-":
                        double N, NZ;
                        N = Convert.ToDouble(textBox1.Text);
                        NZ = -N;
                        textBox1.Text = NZ.ToString();
                        break;
                    case ",":
                        string pr = textBox1.Text;
                        if (pr == "")
                            textBox1.Text = textBox1.Text;
                        else
                        {
                            if (pr.Contains(','))
                                textBox1.Text = textBox1.Text;
                            else
                            {
                                if (x == 1) // Чекалка для написания следующего числа
                                {
                                    textBox1.Text = textBox1.Text;
                                }
                                else
                                    textBox1.Text = textBox1.Text + ","; // поставить запятую
                            }
                        }
                        break;
                    case "=":
                        double N1, N2, otvet = 0;
                        N1 = Convert.ToDouble(Numb1);
                        N2 = Convert.ToDouble(textBox1.Text); // взять второе число

                        if (znak2 == "+")
                            otvet = N1 + N2;
                        else if (znak2 == "-")
                            otvet = N1 - N2;
                        else if (znak2 == "*")
                            otvet = N1 * N2;
                        else if (znak2 == "/")
                        {
                            if (N2 == 0)
                            {
                                textBox1.Text = "На ноль делить нельзя";
                                x = 1;
                                return;
                            }

                            else
                                otvet = N1 / N2;
                        }
                        else if (znak == "=")
                            otvet = Convert.ToDouble(textBox1.Text);
                        N1 = 0;
                        textBox1.Text = otvet.ToString();
                        x = 1; // для чекалки
                        break;
                }
            }
        }
        
    }
}
