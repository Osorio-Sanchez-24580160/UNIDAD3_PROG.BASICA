namespace Practica_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal;
            cal = double.Parse(textBox1.Text);
            if (cal < 7.0) MessageBox.Show(" REPROBADO"); else MessageBox.Show(" APROBADO");
        }
    }
}
