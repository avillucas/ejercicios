namespace Ejercicio_25
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binario a Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decimal a Binario";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(161, 48);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 20);
            this.txtBinario.TabIndex = 2;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(290, 44);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(75, 23);
            this.btnBinToDec.TabIndex = 3;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoDec.Location = new System.Drawing.Point(394, 47);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoDec.TabIndex = 4;
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.AcceptsReturn = true;
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoBin.Location = new System.Drawing.Point(394, 115);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoBin.TabIndex = 7;
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(290, 112);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(75, 23);
            this.btnDecToBin.TabIndex = 6;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(161, 116);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtDecimal;
    }
}

