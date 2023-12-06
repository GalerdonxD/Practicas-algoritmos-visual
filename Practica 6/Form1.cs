namespace Practica_6
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
            float Base, Altura, Area;

            Base = float.Parse(textBox1.Text);
            Altura = float.Parse(textBox2.Text);

            Area = (Base * Altura) / 2;

            textBox3.Text = Area.ToString();

        }
    }
}