using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAula
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0;
            Double n2 = 0.0;
            Double resultado = 0.0;

            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 + n2;

            lblResultado.Text = Convert.ToString(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0;
            Double n2 = 0.0;
            Double resultado = 0.0;

            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 - n2;

            lblResultado.Text = Convert.ToString(resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0;
            Double n2 = 0.0;
            Double resultado = 0.0;

            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 * n2;

            lblResultado.Text = Convert.ToString(resultado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0;
            Double n2 = 0.0;
            Double resultado = 0.0;

            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 / n2;

            lblResultado.Text = Convert.ToString(resultado);
        }
    }
}
