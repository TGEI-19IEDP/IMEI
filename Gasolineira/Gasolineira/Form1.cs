using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolineira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Tem a certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double litros, resultado;
            litros = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                resultado = (litros * 1.05);
                label5.Text= resultado.ToString("C");
            } 
            else if(radioButton2.Checked == true)
            {
                resultado = (litros * 1.15);
                label5.Text = resultado.ToString("C");
            }
            else if(radioButton3.Checked == true)
            {
                resultado = (litros * 0.80);

                label5.Text = resultado.ToString("C");
            }
        }
    }
}
