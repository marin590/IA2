namespace IA2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.epocas = new System.Windows.Forms.NumericUpDown();
            this.learningRate = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Plano = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.muestraEpocas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epocas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plano)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.muestraEpocas);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.epocas);
            this.panel1.Controls.Add(this.learningRate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Plano);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1073, 735);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(674, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Entrenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // epocas
            // 
            this.epocas.Location = new System.Drawing.Point(685, 137);
            this.epocas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.epocas.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.epocas.Name = "epocas";
            this.epocas.Size = new System.Drawing.Size(53, 20);
            this.epocas.TabIndex = 9;
            this.epocas.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // learningRate
            // 
            this.learningRate.DecimalPlaces = 1;
            this.learningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.learningRate.Location = new System.Drawing.Point(662, 102);
            this.learningRate.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            this.learningRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.learningRate.Name = "learningRate";
            this.learningRate.Size = new System.Drawing.Size(41, 20);
            this.learningRate.TabIndex = 8;
            this.learningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Numero de epocas: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Learning Rate: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(667, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Perceptron";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "- X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "- Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "+ Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+ X";
            // 
            // Plano
            // 
            this.Plano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Plano.Location = new System.Drawing.Point(38, 24);
            this.Plano.MaximumSize = new System.Drawing.Size(500, 500);
            this.Plano.MinimumSize = new System.Drawing.Size(500, 500);
            this.Plano.Name = "Plano";
            this.Plano.Size = new System.Drawing.Size(500, 500);
            this.Plano.TabIndex = 0;
            this.Plano.TabStop = false;
            this.Plano.Paint += new System.Windows.Forms.PaintEventHandler(this.Plano_Paint);
            this.Plano.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Plano_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(667, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 37);
            this.label8.TabIndex = 11;
            this.label8.Text = "Resultados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 348);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Total de epocas realizadas: ";
            // 
            // muestraEpocas
            // 
            this.muestraEpocas.AutoSize = true;
            this.muestraEpocas.Location = new System.Drawing.Point(722, 348);
            this.muestraEpocas.Name = "muestraEpocas";
            this.muestraEpocas.Size = new System.Drawing.Size(13, 13);
            this.muestraEpocas.TabIndex = 13;
            this.muestraEpocas.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 735);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Inteligencia Artificial 2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epocas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plano)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Plano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown learningRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown epocas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label muestraEpocas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

