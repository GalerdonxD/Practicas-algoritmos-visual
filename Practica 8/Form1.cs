namespace Practica_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se delcaran las variables a usar (Area, Volumen, Radio) de la circunferencia
            double ACir, VCir, RCir;

            //Convierte el contenido del txt "radio" al valor de RCir
            RCir = double.Parse(radioCir.Text);

            //Se realizan las operaciones para obtener el volumen y area
            ACir = 4 * Math.PI * Math.Pow(RCir, 2);
            VCir = 4 / 3 * Math.PI * Math.Pow(RCir, 3);

            //Hace que aparezcan los resultados del area y volumen
            areaCir.Text = ACir.ToString();
            volumenCir.Text = VCir.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Borra el contenido de los textbox
            radioCir.Text = " ";
            areaCir.Text = " ";
            volumenCir.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Termina de ejecutar la aplicacion
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Se delcaran las variables a usar
            double Bt, Ht, At;

            Bt = double.Parse(baseT.Text);
            Ht = double.Parse(alturaT.Text);

            At = Bt * Ht / 2;

            areaT.Text = At.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Borra el contenido de los textbox
            baseT.Text = " ";
            alturaT.Text = " ";
            areaT.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Termina de ejecutar la aplicacion
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Se delcaran las variables a usar
            double LCu, ACu, VCu;

            LCu = double.Parse(ladoCu.Text);

            ACu = 6 * Math.Pow(LCu, 2);
            VCu = Math.Pow(LCu, 3);

            areaCu.Text = ACu.ToString();
            volumenCu.Text = VCu.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Borra el contenido de los textbox
            ladoCu.Text = " ";
            areaCu.Text = " ";
            volumenCu.Text = " ";
        }

        private void volumenCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Termina de ejecutar la aplicacion
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //Se delcaran las variables a usar
            double RCi, HCi, ACi, VCi;

            RCi = double.Parse(radioCi.Text);
            HCi = double.Parse(alturaCi.Text);

            ACi = (2 * Math.PI * RCi * HCi) + (2 * Math.PI * Math.Pow(RCi, 2));
            VCi = Math.PI * HCi * Math.Pow(RCi, 2);

            areaCi.Text = ACi.ToString();
            volumenCi.Text = VCi.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Borra el contenido de los textbox
            radioCi.Text = " ";
            alturaCi.Text = " ";
            areaCi.Text = " ";
            volumenCi.Text = " ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //Termina de ejecutar la aplicacion
            Application.Exit();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //Se delcaran las variables a usar
            double DMa, DMe, AR;

            DMa = double.Parse(diagonalMa.Text);
            DMe = double.Parse(diagonalMe.Text);

            AR = (DMa * DMe) / 2;

            areaR.Text = AR.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //Borra el contenido de los textbox
            diagonalMe.Text = " ";
            diagonalMa.Text = " ";
            areaR.Text = " ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //Termina de ejecutar la aplicacion
            Application.Exit();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //Se delcaran las variables a usar
            double LO, AO, VO;

            LO = double.Parse(lateralO.Text);

            AO = 2 * Math.Sqrt(3) * Math.Pow(LO, 2);
            VO = (Math.Sqrt(2) / 3) * Math.Pow(LO, 3);

            areaO.Text = AO.ToString();
            volumenO.Text = VO.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //Borra el contenido de los textbox
            lateralO.Text = " ";
            areaO.Text = " ";
            volumenO.Text = " ";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Termina de ejecutar la aplicacion
            Application.Exit();
        }
    }
}