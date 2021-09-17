using Gerenciador_Cinema.Controlador.ModuleControladorLogin;
using Gerenciador_Cinema.Dominio.ModuleLogin;
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
    public partial class TelaLogin : Form
    {
        private Login login = null;
        private readonly ControladorLogin controlador;

        public TelaLogin(ControladorLogin controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
        }

        public Login Login
        {
            get { return login; }
        }


        private void btnLogar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            login = new Login(email, senha);

            bool resultado = VerificaLogin(login);

            if (resultado != true)
            {
                MessageBox.Show("Login inválido!", "Tente novamente!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                TelaPrincipal tela = new TelaPrincipal();
                tela.ShowDialog();
            }
        }

        private bool VerificaLogin(Login login)
        {
            List<Login> logins = controlador.SelecionarTodos();
            foreach (var item in logins)
            {
                if (item.Email.Equals(login.Email) && item.Senha.Equals(login.Senha))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
