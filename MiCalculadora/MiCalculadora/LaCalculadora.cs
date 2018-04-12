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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LaCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperar.Text = "+";
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
            //validar si es un numero 
            if (!validateInput(txtNumero1.Text))
            {
                MessageBox.Show("Debe ingresar un numero en el operando", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validar si es un numero 
            if (!validateInput(txtNumero2.Text))
            {
                MessageBox.Show("Debe ingresar un numero en el operando", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double resultado = Calculadora.Operar(new Numero(txtNumero1.Text),new Numero(txtNumero2.Text), cmbOperar.Text);
            lblResultado.Text = resultado.ToString();
            //se vuelve decimal de nuevo 
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// . El evento click del botón btnConvertirABinario convertirá el resultado, de existir, a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {            
            string strResultado = Numero.DecimalABinario(lblResultado.Text);
            lblResultado.Text = strResultado;
            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;            
        }

        /// <summary>
        /// 0. El evento click del botón btnConvertirADecimal convertirá el resultado, de existir y ser binario, a decimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {          
            string strResultado = Numero.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = strResultado;
            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;        
        }

        /// <summary>
        /// Determina si lo ingresado puede ser convertido a un numero
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        /// <remaremarks> Mejorar la forma de determinar el proceso </remaremarks>        
        private static bool validateInput(string text){
            double numero;
            return double.TryParse(text,out numero);
                
        }    

    }
}
