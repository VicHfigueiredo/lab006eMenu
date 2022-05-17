using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab006.LabCalculos.Lab006
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        public void MaiorDeTres()
        {
            int valor1 = Convert.ToInt32(nudValor1.Text);
            int valor2 = Convert.ToInt32(nudValor2.Text);
            int valor3 = Convert.ToInt32(nudValor3.Text);
            int maior = 0;

            if (valor1 == valor2 && valor2 == valor3)
            {
                lblResultado.Text = "Os três valores são iguais.";
                return;
            }
            maior = valor1;

            if (valor2 > maior)
            {
                maior = valor2;
            }

            if(valor3 > maior)
            {
                maior = valor3;
            }
            lblResultado.Text = "O maior número é" + maior;
            //lblResultado.Text = ;
            //lblResultado.Text = valor1.ToString() + valor2.ToString() + valor3.ToString();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MaiorDeTres();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
