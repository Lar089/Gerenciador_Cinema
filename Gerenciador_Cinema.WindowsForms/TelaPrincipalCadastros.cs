using Gerenciador_Cinema.WindowsForms.Features.ModuleSala;
using Gerenciador_Cinema.WindowsForms.Shared;
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
    public partial class TelaPrincipalCadastros : UserControl
    {
        private ICadastravel operacoes;
        public static TelaPrincipalCadastros Instancia;

        public TelaPrincipalCadastros()
        {
            InitializeComponent();
            Instancia = this;
        }

        public void AtualizarRodape(string mensagem)
        {
            statusLabeTela.Text = mensagem;
        }

        private void MenuItemSalas_Click(object sender, EventArgs e)
        {
            ConfiguracaoSalaTooBox configuracao = new ConfiguracaoSalaTooBox();

            ConfigurarToolBox(configuracao);

            AtualizarRodape(configuracao.TipoCadastro);

            operacoes = new OperacoesTarefa(new ControladorTarefa());

            ConfigurarPainelRegistros();
        }

        private void MenuItemFilmes_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemSessoes_Click(object sender, EventArgs e)
        {

        }
    }
}
