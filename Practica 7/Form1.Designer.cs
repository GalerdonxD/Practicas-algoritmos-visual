namespace Practica_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            valor = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox3 = new GroupBox();
            label3 = new Label();
            resultado = new TextBox();
            label2 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(valor);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 60);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // valor
            // 
            valor.Location = new Point(106, 24);
            valor.Name = "valor";
            valor.Size = new Size(112, 23);
            valor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese Valor:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(25, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 110);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opciones de conversion";
            // 
            // button3
            // 
            button3.Location = new Point(70, 69);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(120, 40);
            button2.Name = "button2";
            button2.Size = new Size(98, 23);
            button2.TabIndex = 1;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 40);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 0;
            button1.Text = "FAHRENHEIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(resultado);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(25, 224);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(228, 113);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 65);
            label3.Name = "label3";
            label3.Size = new Size(15, 15);
            label3.TabIndex = 2;
            label3.Text = "~";
            // 
            // resultado
            // 
            resultado.Location = new Point(22, 62);
            resultado.Name = "resultado";
            resultado.Size = new Size(100, 23);
            resultado.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 33);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 0;
            label2.Text = "Equivalente en Grados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 359);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Conversor de temperatura";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox valor;
        private Label label1;
        private GroupBox groupBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox3;
        private TextBox resultado;
        private Label label2;
        private Label label3;
    }
}