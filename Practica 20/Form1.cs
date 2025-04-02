namespace Practica_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(textBox1.Text);
            if (age <= 12)
            {
                textBox2.Text = "Eres un niño";
            }
            if ((age > 12) && (age < 18))
            {
                textBox2.Text = "Eres un adolescente";
            }
            if ((age >= 18) && (age < 60))
            {
                textBox2.Text = "Eres un adulto";
            }
            if (age >= 60)
            {
                textBox2.Text = "Eres un adulto mayor";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
