using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os números do Form:
                double B1, A2, resultado;

                B1 = double.Parse(txbBase.Text);
                A2 = double.Parse(txbAltura.Text);

                // Fazendo E Mostrando no Campo Resultado A Operação:

                resultado = B1 * A2 / 2;

                txbResultado.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Dados invalidos informados!");
                // Limpar os txbs:
                txbBase.Clear();
                txbAltura.Clear();
                txbResultado.Clear();
            }
            
        }

    }
}
