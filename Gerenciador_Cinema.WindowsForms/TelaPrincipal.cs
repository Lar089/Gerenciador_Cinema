using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_Cinema.WindowsForms
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            panelTelaPrincipal.Controls.Add(new TelaPrincipalCadastros());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
        }
    }
}
