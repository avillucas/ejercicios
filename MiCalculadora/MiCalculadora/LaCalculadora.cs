using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class LaCalculadora : Form
    {
        public LaCalculadora()
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
            lblResultado.Text="";
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperar.Text = "";            
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
            if (lblResultado.Text.Length > 0) {
                string strResultado = Numero.DecimalABinario(lblResultado.Text);
                lblResultado.Text = strResultado;
            }
        }

        /// <summary>
        /// 0. El evento click del botón btnConvertirADecimal convertirá el resultado, de existir y ser binario, a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            //TODO validar si el numero es binario            
            bool esBinario = true;
            if (lblResultado.Text.Length > 0 && esBinario )
            {
                string strResultado = Numero.BinarioDecimal(lblResultado.Text);
                lblResultado.Text = strResultado;
            }
        }
    }
}
