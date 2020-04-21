using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operações_Aritméticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a + b;
                label1.Text = "+";
                label2.Text = "=";
                label3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Verifique os dados introduzidos","Erro");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                double a, b, c;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a - b;
                label1.Text = "-";
                label2.Text = "=";
                label3.Text = c.ToString();
            }
            catch 
            { 
                MessageBox.Show("Verifique os dados introduzidos", "Erro"); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a * b;
                label1.Text = "*";
                label2.Text = "=";
                label3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Verifique os dados introduzidos", "Erro");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a / b;
                label1.Text = "/";
                label2.Text = "=";
                label3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Verifique os dados introduzidos", "Erro");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = 1;
                label1.Text = "^";
                label2.Text = "=";
                for (double i = 1; i <= b; i++)
                {
                    c *= a;
                }
                label3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Verifique os dados introduzidos", "Erro");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                int c;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToInt32(a / b);
                label1.Text = "/";
                label2.Text = "=";
                label3.Text = c.ToString();
            }
            catch
            {
                MessageBox.Show("Verifique os dados introduzidos", "Erro");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c, d;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = a / b;
                label1.Text = "/";
                label2.Text = "=";
                label3.Text = c.ToString();
                d = a % b;
                MessageBox.Show(Convert.ToString(d));

            }
            catch
            {
                MessageBox.Show("Verifique os dados introduzidos", "Erro");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
