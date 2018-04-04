using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnidadesDeMedida;

namespace Ejercicio_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCelsius_Click(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(txtCelcius.Text, out numero))
            {
                Celsius c = new Celsius(numero);
                Fahrenheit f = (Fahrenheit)c;
                Kelvin k = (Kelvin)c;
                txtCelciusFahrenheit.Text = f.GetCantidad().ToString();
                txtCelciusCelsius.Text = c.GetCantidad().ToString();
                txtCelciusKelvin.Text = k.GetCantidad().ToString();
            }
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(txtKelvin.Text, out numero))
            {
                Kelvin k = new Kelvin(numero);
                Celsius c = (Celsius)k;
                Fahrenheit f = (Fahrenheit)k;
                txtKelvinFahrenheit.Text = f.GetCantidad().ToString();
                txtKelvinCelsius.Text = c.GetCantidad().ToString();
                txtKelvinKelvin.Text = k.GetCantidad().ToString();
            }
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(txtFahrenheit.Text, out numero))
            {
                Fahrenheit f = new Fahrenheit(numero);
                Celsius c = (Celsius)f;
                Kelvin k = (Kelvin)f;
                txtFahrenheitFahrenheit.Text = f.GetCantidad().ToString();
                txtFahrenheitCelcius.Text = c.GetCantidad().ToString();
                txtFahrenheitKelvin.Text = k.GetCantidad().ToString();
            }
        }
    }
}
