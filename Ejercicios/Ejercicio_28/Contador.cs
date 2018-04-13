using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Contador : Form
    {
        public Contador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Queue<string> top3 =  Procesador.Procesar(txtContenido.Text);
            StringBuilder top3Str = new StringBuilder();
            foreach( string ranked in top3){
                top3Str.AppendLine(ranked);
            }
            MessageBox.Show(top3Str.ToString(), "TOP 3", MessageBoxButtons.OK);
        }
    }
}
