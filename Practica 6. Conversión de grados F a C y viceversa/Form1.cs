using System.Drawing;

namespace Grados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, farh1;
            v1 = double.Parse(valor.Text);
            farh1 = v1 * (9.0 / 5.0) + 32;
            Resultado.Text = farh1.ToString();
            etiqueta.Text = " Fahrenheit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;
            v1 = double.Parse(valor.Text);
            cent1 = (v1 - 32) * (5.0 / 9.0);
            Resultado.Text = cent1.ToString();
            etiqueta.Text = " Centigrados";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            valor.Text = " ";
            Resultado.Text = " ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
