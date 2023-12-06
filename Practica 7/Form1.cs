namespace Practica_7
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

            farh1 = v1 * 1.8 + 32;

            resultado.Text = farh1.ToString();

            label3.Text = "Fahrenheit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cent1;

            v1 = double.Parse(valor.Text);

            cent1 = (v1 - 32) / 1.8;

            resultado.Text = cent1.ToString();

            label3.Text = "Centígrados";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor.Text = " ";
            resultado.Text = " ";
        }
    }
}