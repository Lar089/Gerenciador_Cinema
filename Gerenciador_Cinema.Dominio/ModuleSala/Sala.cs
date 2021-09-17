using Gerenciador_Cinema.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.Dominio.ModuleSala
{
    public class Sala : EntidadeBase
    {
        public string Nome { get; }
        public int QtdAssentos { get; }

        public Sala(string nome, int qtdAssentos)
        {
            Nome = nome;
            QtdAssentos = qtdAssentos;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Sala);
        }

        public bool Equals(Sala obj)
        {
            return obj is Sala sala &&
                   Nome == sala.Nome &&
                   QtdAssentos == sala.QtdAssentos;
        }

        public override int GetHashCode()
        {
            int hashCode = -979129020;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + QtdAssentos.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            return "ESTA_VALIDO";
        }
    }
}
