using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversores;

namespace Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            string resultado = "";
            try
            {
                resultado = (string)(NumeroDecimal)(NumeroBinario)txtBinario.Text;
            }
            catch (Exception) {
                resultado = "Conversion invalida";
            }
            txtResultadoDec.Text = resultado;
        }


        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            string resultado = "Conversion invalida";
            double numero;
            if (double.TryParse(txtDecimal.Text, out numero))
            {
                resultado = (string)(NumeroBinario)(NumeroDecimal)numero;
            }
            txtResultadoBin.Text = resultado;
            
        }
    }
}
