using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab006.LabCalculos.Lab007
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculo();
        }

        private void Calculo()
        {
            decimal valor = 0;
            decimal porcento = 0;
            decimal valorfinal = 0;

            valor = Convert.ToDecimal(tbxValor.Text);
            //porcento = Convert.ToDecimal(tbxfrete.Text);
            
            switch(cbxUF.SelectedItem.ToString())
            {
                case "AM":
                    porcento = 0.6m;
                    break;
                case "MG":
                    porcento = 0.35m;
                    break;
                case "RJ":
                    porcento = 0.3m;
                    break;
                case "SP":
                    porcento = 0.2m;
                    break;
                default:
                    porcento = 0.75m;
                    break;
            }

            tbxfrete.Text = porcento.ToString();
            valorfinal = valor * (1 + porcento);

            lblResultado.Text = valorfinal.ToString();

        }
    }
}
