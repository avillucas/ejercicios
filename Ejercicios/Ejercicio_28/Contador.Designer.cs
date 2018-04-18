namespace Ejercicio_28
{
    partial class Contador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contador));
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(13, 13);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(836, 199);
            this.txtContenido.TabIndex = 0;
            this.txtContenido.Text = resources.GetString("txtContenido.Text");
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(774, 218);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 262);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtContenido);
            this.Name = "Contador";
            this.Text = "Contador de palabras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Button btnCalcular;
    }
}