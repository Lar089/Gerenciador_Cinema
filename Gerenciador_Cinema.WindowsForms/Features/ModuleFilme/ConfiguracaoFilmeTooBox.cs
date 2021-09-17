using Gerenciador_Cinema.WindowsForms.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.WindowsForms.Features.ModuleFilme
{
    public class ConfiguracaoFilmeTooBox : IConfiguracaoToolBox
    {
        public string ToolTipAdicionar
        {
            get { return "Adicionar um novo Filme"; }
        }

        public string TipoCadastro
        {
            get { return "Filme"; }
        }

        public string ToolTipEditar
        {
            get { return "Editar um Filme"; }
        }

        public string ToolTipExcluir
        {
            get { return "Excluir um Filme"; }
        }
    }
}
