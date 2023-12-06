namespace Practica_3
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
           //Se declara lavariable "resultado"
            int resultado;

            //convierte los valores de textBox1 y 2 a enteros para poder ser mostrados
            resultado = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);

            //convierte la variable a tipo cadena para poder ser mostrada en resultado
            textBox3.Text = resultado.ToString();
        }
    }
}