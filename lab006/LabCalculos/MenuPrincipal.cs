using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab006;


namespace lab006.LabCalculos
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMaior_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lab006.TelaPrincipal maior = new Lab006.TelaPrincipal();
              maior.ShowDialog();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            Lab007.TelaPrincipal frete = new Lab007.TelaPrincipal();
            frete.ShowDialog();
        }
    }
}
