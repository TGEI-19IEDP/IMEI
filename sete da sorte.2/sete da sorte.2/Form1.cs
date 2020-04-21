using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sete_da_sorte._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                Application.Exit(); // or this.Close();
            }
            //MessageBox.Show("Deseja sair?");
            //if (
            //Application.Exit();
            //{

            //}
            //else
            //{

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10);
            int b = rnd.Next(1, 10);
            int c = rnd.Next(1, 10);
            label1.Text = Convert.ToString(a);
            label2.Text = Convert.ToString(b);
            label3.Text = Convert.ToString(c);
            if (a == 7 && b == 7 || a==7 && c == 7 || b==7 && c==7)
            //if (a == 7 || c == 7 || b == 7)
            {
                MessageBox.Show("Voçê ganhou!!");
            }
            else
            {
                MessageBox.Show("Tente de novo!");
            }
        }
    }
}
