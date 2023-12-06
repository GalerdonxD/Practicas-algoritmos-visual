namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se declaran las variables
            double radio, altura, Basearea, Lateralarea, Areat, volumen;

            //Se establece que los valores de entreada son el radio y la altura
            radio = double.Parse(Radius.Text);
            altura = double.Parse(Height.Text);

            //Se realizan las operaciones a calcular
            Basearea = radio * radio * Math.PI;
            Lateralarea = altura * radio * Math.PI * 2;
            Areat = 2 * Math.PI * radio * (altura + radio);
            volumen = Math.PI * radio * radio * altura;

            //Se dan los valores de salida despues de haber sido calculados
            BA.Text = Basearea.ToString("0.##");
            LA.Text = Lateralarea.ToString("0.##");
            A.Text = Areat.ToString("0.##");
            V.Text = volumen.ToString("0.##");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //La funcion es borrar el contenido en los textBox
            Radius.Text = " ";
            Height.Text = " ";
            BA.Text = " ";
            LA.Text = " ";
            A.Text = " ";
            V.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Sirve para salir de la aplicacion
            Application.Exit();
        }
    }
}