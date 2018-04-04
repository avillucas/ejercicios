using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace ConversorDeDinero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEuro_Click(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(TxtEuro.Text,out numero)){
                Euro euro = new Euro(numero);
                TxtEuroEuro.Text = numero.ToString();
                Dolar dolar = (Dolar)euro;
                TxtEuroDolar.Text = dolar.GetCantidad().ToString();
                Peso peso = (Peso)euro;
                TxtEuroPeso.Text = peso.GetCantidad().ToString();
            }

        }

        private void BtnDolar_Click(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(TxtDolar.Text, out numero))
            {
                Dolar dolar = new Dolar(numero);
                TxtDolarDolar.Text = numero.ToString();
                Euro euro = (Euro)dolar;
                TxtDolarEuro.Text = euro.GetCantidad().ToString();
                Peso peso = (Peso)dolar;
                TxtDolarPeso.Text = peso.GetCantidad().ToString();
            }
        }

        private void BtnPeso_Click(object sender, EventArgs e)
        {

            double numero;
            if (double.TryParse(TxtPeso.Text, out numero))
            {
                Peso peso = new Peso(numero);
                TxtPesoPeso.Text = numero.ToString();
                Dolar dolar = (Dolar)peso;
                TxtPesoDolar.Text = dolar.GetCantidad().ToString();
                Euro euro = (Euro)peso;
                TxtPesoEuro.Text = euro.GetCantidad().ToString();
            }

        }
    }
}
