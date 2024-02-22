using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр_15
{
    public partial class Form1 : Form
    {
        public string Number1;
        public string Number2;
        public bool Check = false;
        public string znak;
        public string Error = "Ошибка";
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Check)
            {
                Check = false;
                textBox1.Text = "";
            }


            Button Sender = (Button)sender;
            textBox1.Text = textBox1.Text + Sender.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button Sender = (Button)sender;
            znak = Sender.Text;
            Number1 = textBox1.Text;
            Check = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double NumberOne, NumberTwo, otvet = 0;
            NumberOne = Convert.ToDouble(Number1);
            NumberTwo = Convert.ToDouble(textBox1.Text);

            if (znak == "+")
                otvet = NumberOne + NumberTwo;
            else if (znak == "-")
                otvet = NumberOne - NumberTwo;
            else if (znak == "*")
                otvet = NumberOne * NumberTwo;
            else if (znak == "/")
            {
                if (NumberTwo == 0)
                {
                    textBox1.Text = "На ноль делить нельзя";
                    return;
                }

                else
                    otvet = NumberOne / NumberTwo;
            }


            znak = "=";
            textBox1.Text = otvet.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double otvet;
            double Number = Convert.ToDouble(textBox1.Text);
            if (Number >= 0)
            {
                otvet = Math.Sqrt(Number);
                textBox1.Text = otvet.ToString();
            }
            else
                textBox1.Text = "Ошибка";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double Number, otvet;
            Number = Convert.ToDouble(textBox1.Text);
            otvet = -Number;
            textBox1.Text = otvet.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
