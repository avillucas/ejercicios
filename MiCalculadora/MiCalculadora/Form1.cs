using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// El método Limpiar será llamado por el evento click del botón btnLimpiar y borrará
        /// los datos de los TextBox, ComboBox y Label de la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text="";
            txtOperando1.Text = "";
            txtOperando2.Text = "";
            //TODO analizar si hay que devolver el combox a algun valor
        }

        /// <summary>
        /// El método Operar será estático recibirá los dos números y el operador para luego
        /// llamar al método Operar de Calculadora y retornar el resultado al método de evento
        /// del botón btnOperar que reflejará el resultado en el Label txtResultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// . El evento click del botón btnConvertirABinario convertirá el resultado, de existir, a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 0. El evento click del botón btnConvertirADecimal convertirá el resultado, de existir y ser binario, a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

        }
    }
}
