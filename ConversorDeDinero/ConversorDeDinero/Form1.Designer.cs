namespace ConversorDeDinero
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
            this.BtnEuro = new System.Windows.Forms.Button();
            this.LblEuro = new System.Windows.Forms.Label();
            this.TxtEuroEuro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEuroDolar = new System.Windows.Forms.TextBox();
            this.TxtEuroPeso = new System.Windows.Forms.TextBox();
            this.TxtEuro = new System.Windows.Forms.TextBox();
            this.TxtDolar = new System.Windows.Forms.TextBox();
            this.TxtDolarPeso = new System.Windows.Forms.TextBox();
            this.TxtDolarDolar = new System.Windows.Forms.TextBox();
            this.TxtDolarEuro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDolar = new System.Windows.Forms.Button();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.TxtPesoPeso = new System.Windows.Forms.TextBox();
            this.TxtPesoDolar = new System.Windows.Forms.TextBox();
            this.TxtPesoEuro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnPeso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEuro
            // 
            this.BtnEuro.Location = new System.Drawing.Point(204, 59);
            this.BtnEuro.Name = "BtnEuro";
            this.BtnEuro.Size = new System.Drawing.Size(40, 23);
            this.BtnEuro.TabIndex = 0;
            this.BtnEuro.Text = "->";
            this.BtnEuro.UseVisualStyleBackColor = true;
            this.BtnEuro.Click += new System.EventHandler(this.BtnEuro_Click);
            // 
            // LblEuro
            // 
            this.LblEuro.AutoSize = true;
            this.LblEuro.Location = new System.Drawing.Point(21, 64);
            this.LblEuro.Name = "LblEuro";
            this.LblEuro.Size = new System.Drawing.Size(29, 13);
            this.LblEuro.TabIndex = 1;
            this.LblEuro.Text = "Euro";
            // 
            // TxtEuroEuro
            // 
            this.TxtEuroEuro.Enabled = false;
            this.TxtEuroEuro.Location = new System.Drawing.Point(269, 61);
            this.TxtEuroEuro.Name = "TxtEuroEuro";
            this.TxtEuroEuro.Size = new System.Drawing.Size(100, 20);
            this.TxtEuroEuro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Euro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dolar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso";
            // 
            // TxtEuroDolar
            // 
            this.TxtEuroDolar.Enabled = false;
            this.TxtEuroDolar.Location = new System.Drawing.Point(396, 61);
            this.TxtEuroDolar.Name = "TxtEuroDolar";
            this.TxtEuroDolar.Size = new System.Drawing.Size(100, 20);
            this.TxtEuroDolar.TabIndex = 6;
            // 
            // TxtEuroPeso
            // 
            this.TxtEuroPeso.Enabled = false;
            this.TxtEuroPeso.Location = new System.Drawing.Point(523, 61);
            this.TxtEuroPeso.Name = "TxtEuroPeso";
            this.TxtEuroPeso.Size = new System.Drawing.Size(100, 20);
            this.TxtEuroPeso.TabIndex = 7;
            // 
            // TxtEuro
            // 
            this.TxtEuro.Location = new System.Drawing.Point(77, 60);
            this.TxtEuro.Name = "TxtEuro";
            this.TxtEuro.Size = new System.Drawing.Size(100, 20);
            this.TxtEuro.TabIndex = 8;
            // 
            // TxtDolar
            // 
            this.TxtDolar.Location = new System.Drawing.Point(77, 100);
            this.TxtDolar.Name = "TxtDolar";
            this.TxtDolar.Size = new System.Drawing.Size(100, 20);
            this.TxtDolar.TabIndex = 14;
            // 
            // TxtDolarPeso
            // 
            this.TxtDolarPeso.Enabled = false;
            this.TxtDolarPeso.Location = new System.Drawing.Point(523, 101);
            this.TxtDolarPeso.Name = "TxtDolarPeso";
            this.TxtDolarPeso.Size = new System.Drawing.Size(100, 20);
            this.TxtDolarPeso.TabIndex = 13;
            // 
            // TxtDolarDolar
            // 
            this.TxtDolarDolar.Enabled = false;
            this.TxtDolarDolar.Location = new System.Drawing.Point(396, 101);
            this.TxtDolarDolar.Name = "TxtDolarDolar";
            this.TxtDolarDolar.Size = new System.Drawing.Size(100, 20);
            this.TxtDolarDolar.TabIndex = 12;
            // 
            // TxtDolarEuro
            // 
            this.TxtDolarEuro.Enabled = false;
            this.TxtDolarEuro.Location = new System.Drawing.Point(269, 101);
            this.TxtDolarEuro.Name = "TxtDolarEuro";
            this.TxtDolarEuro.Size = new System.Drawing.Size(100, 20);
            this.TxtDolarEuro.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dolar";
            // 
            // BtnDolar
            // 
            this.BtnDolar.Location = new System.Drawing.Point(204, 99);
            this.BtnDolar.Name = "BtnDolar";
            this.BtnDolar.Size = new System.Drawing.Size(40, 23);
            this.BtnDolar.TabIndex = 9;
            this.BtnDolar.Text = "->";
            this.BtnDolar.UseVisualStyleBackColor = true;
            this.BtnDolar.Click += new System.EventHandler(this.BtnDolar_Click);
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(77, 137);
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 20);
            this.TxtPeso.TabIndex = 20;
            // 
            // TxtPesoPeso
            // 
            this.TxtPesoPeso.Enabled = false;
            this.TxtPesoPeso.Location = new System.Drawing.Point(523, 138);
            this.TxtPesoPeso.Name = "TxtPesoPeso";
            this.TxtPesoPeso.Size = new System.Drawing.Size(100, 20);
            this.TxtPesoPeso.TabIndex = 19;
            // 
            // TxtPesoDolar
            // 
            this.TxtPesoDolar.Enabled = false;
            this.TxtPesoDolar.Location = new System.Drawing.Point(396, 138);
            this.TxtPesoDolar.Name = "TxtPesoDolar";
            this.TxtPesoDolar.Size = new System.Drawing.Size(100, 20);
            this.TxtPesoDolar.TabIndex = 18;
            // 
            // TxtPesoEuro
            // 
            this.TxtPesoEuro.Enabled = false;
            this.TxtPesoEuro.Location = new System.Drawing.Point(269, 138);
            this.TxtPesoEuro.Name = "TxtPesoEuro";
            this.TxtPesoEuro.Size = new System.Drawing.Size(100, 20);
            this.TxtPesoEuro.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Peso";
            // 
            // BtnPeso
            // 
            this.BtnPeso.Location = new System.Drawing.Point(204, 136);
            this.BtnPeso.Name = "BtnPeso";
            this.BtnPeso.Size = new System.Drawing.Size(40, 23);
            this.BtnPeso.TabIndex = 15;
            this.BtnPeso.Text = "->";
            this.BtnPeso.UseVisualStyleBackColor = true;
            this.BtnPeso.Click += new System.EventHandler(this.BtnPeso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.TxtPesoPeso);
            this.Controls.Add(this.TxtPesoDolar);
            this.Controls.Add(this.TxtPesoEuro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnPeso);
            this.Controls.Add(this.TxtDolar);
            this.Controls.Add(this.TxtDolarPeso);
            this.Controls.Add(this.TxtDolarDolar);
            this.Controls.Add(this.TxtDolarEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnDolar);
            this.Controls.Add(this.TxtEuro);
            this.Controls.Add(this.TxtEuroPeso);
            this.Controls.Add(this.TxtEuroDolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtEuroEuro);
            this.Controls.Add(this.LblEuro);
            this.Controls.Add(this.BtnEuro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEuro;
        private System.Windows.Forms.Label LblEuro;
        private System.Windows.Forms.TextBox TxtEuroEuro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEuroDolar;
        private System.Windows.Forms.TextBox TxtEuroPeso;
        private System.Windows.Forms.TextBox TxtEuro;
        private System.Windows.Forms.TextBox TxtDolar;
        private System.Windows.Forms.TextBox TxtDolarPeso;
        private System.Windows.Forms.TextBox TxtDolarDolar;
        private System.Windows.Forms.TextBox TxtDolarEuro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDolar;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.TextBox TxtPesoPeso;
        private System.Windows.Forms.TextBox TxtPesoDolar;
        private System.Windows.Forms.TextBox TxtPesoEuro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnPeso;
    }
}

