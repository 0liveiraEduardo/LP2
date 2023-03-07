using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        double Raio, Altura;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double volume;
            volume = Math.PI * Math.Pow(Raio, 2) * Altura;
            textBox3.Text = volume.ToString("N2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {       

            if (!double.TryParse(textBox1.Text, out Raio))
            {
                MessageBox.Show("Raio Inválido");
                textBox1.Focus();
            }
            else if (Raio <= 0)
            {
                MessageBox.Show("O raio deve ser maior que zero.");
                textBox1.Focus();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {

            if (!double.TryParse(textBox2.Text, out Altura))
            {
                MessageBox.Show("Altura Inválida");
                textBox2.Focus();
            }
            else if (Altura <= 0)
            {
                MessageBox.Show("A altura deve ser maior que zero.");
                textBox2.Focus();
            }
        }
    }
}
