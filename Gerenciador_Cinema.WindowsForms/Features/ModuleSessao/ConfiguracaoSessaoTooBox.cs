using Gerenciador_Cinema.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.WindowsForms.Features.ModuleSessao
{
    public class ConfiguracaoSessaoTooBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Adicionar uma nova Sessão"; }
        }

        public string TipoCadastro
        {
            get { return "Sessão"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar uma Sessão"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir uma Sessão"; }
        }
    }
}
