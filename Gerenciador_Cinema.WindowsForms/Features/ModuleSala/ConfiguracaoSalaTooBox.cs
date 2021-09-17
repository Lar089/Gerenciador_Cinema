using Gerenciador_Cinema.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.WindowsForms.Features.ModuleSala
{
    public class ConfiguracaoSalaTooBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Adicionar uma nova Sala"; }
        }

        public string TipoCadastro
        {
            get { return "Sala"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar uma Sala"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir uma Sala"; }
        }
    }
}
