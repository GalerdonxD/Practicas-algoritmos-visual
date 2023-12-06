namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label3.Text = "Hola " + this.textBox1.Text + " !!";
        }
    }
}