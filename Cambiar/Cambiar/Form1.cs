using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cambiar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a,b;
            a = Convert.ToDouble(textBox1.Text);
                if (radioButton1.Checked == true)
                {
                    b = a * 0.9796;
                    label1.Text = b.ToString();
                    label3.Text = "Dolares";
                }
                else if (radioButton2.Checked == true)
                {
                    b = a * 0.6274;
                    label1.Text = b.ToString();
                    label3.Text = "Libras";
                }
                else if (radioButton3.Checked == true)
                {
                    b = a * 120.22;
                    label1.Text = b.ToString();
                    label3.Text = "Ienes";
                }
            }
            catch
            {
                MessageBox.Show("Verifique o valor introduzido!","ERROR!!");
            }
        }
    }
}
