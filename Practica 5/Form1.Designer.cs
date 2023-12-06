namespace Practica_5
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
            Radius = new TextBox();
            Height = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            BA = new TextBox();
            LA = new TextBox();
            A = new TextBox();
            V = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Radius
            // 
            Radius.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Radius.Location = new Point(163, 60);
            Radius.Name = "Radius";
            Radius.Size = new Size(146, 33);
            Radius.TabIndex = 0;
            // 
            // Height
            // 
            Height.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Height.Location = new Point(163, 107);
            Height.Name = "Height";
            Height.Size = new Size(146, 33);
            Height.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(33, 170);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(161, 170);
            button2.Name = "button2";
            button2.Size = new Size(95, 38);
            button2.TabIndex = 3;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(279, 171);
            button3.Name = "button3";
            button3.Size = new Size(95, 38);
            button3.TabIndex = 4;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // BA
            // 
            BA.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BA.Location = new Point(163, 244);
            BA.Name = "BA";
            BA.Size = new Size(146, 33);
            BA.TabIndex = 5;
            // 
            // LA
            // 
            LA.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LA.Location = new Point(163, 284);
            LA.Name = "LA";
            LA.Size = new Size(146, 33);
            LA.TabIndex = 6;
            // 
            // A
            // 
            A.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            A.Location = new Point(163, 326);
            A.Name = "A";
            A.Size = new Size(146, 33);
            A.TabIndex = 7;
            // 
            // V
            // 
            V.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            V.Location = new Point(163, 365);
            V.Name = "V";
            V.Size = new Size(146, 33);
            V.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 26);
            label1.TabIndex = 9;
            label1.Text = "Introduce las dimensiones del cilindro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 63);
            label2.Name = "label2";
            label2.Size = new Size(65, 26);
            label2.TabIndex = 10;
            label2.Text = "Radio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 110);
            label3.Name = "label3";
            label3.Size = new Size(69, 26);
            label3.TabIndex = 11;
            label3.Text = "Altura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 244);
            label4.Name = "label4";
            label4.Size = new Size(104, 26);
            label4.TabIndex = 12;
            label4.Text = "Base Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 284);
            label5.Name = "label5";
            label5.Size = new Size(125, 26);
            label5.TabIndex = 13;
            label5.Text = "Lateral Area";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 324);
            label6.Name = "label6";
            label6.Size = new Size(108, 26);
            label6.TabIndex = 14;
            label6.Text = "Area Total";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(33, 368);
            label7.Name = "label7";
            label7.Size = new Size(95, 26);
            label7.TabIndex = 15;
            label7.Text = "Volumen";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(384, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(612, 428);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(V);
            Controls.Add(A);
            Controls.Add(LA);
            Controls.Add(BA);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Height);
            Controls.Add(Radius);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Dimensiones Cilindro Calculator";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Radius;
        private TextBox Height;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox BA;
        private TextBox LA;
        private TextBox A;
        private TextBox V;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
    }
}