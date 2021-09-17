using Gerenciador_Cinema.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.Dominio.ModuleFilme
{
    public class Filme : EntidadeBase
    {

        public byte[] Imagem { get;}
        public string Titulo { get; }
        public string Descricao { get; }
        public TimeSpan Duracao { get; }

        public Filme(byte[] imagem, string titulo, string descricao, TimeSpan duracao)
        {
            Imagem = imagem;
            Titulo = titulo;
            Descricao = descricao;
            Duracao = duracao;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Filme);
        }

        public bool Equals(Filme obj)
        {
            return obj is Filme filme &&
                   Id == filme.Id &&
                   EqualityComparer<byte[]>.Default.Equals(Imagem, filme.Imagem) &&
                   Titulo == filme.Titulo &&
                   Descricao == filme.Descricao &&
                   Duracao.Equals(filme.Duracao);
        }

        public override int GetHashCode()
        {
            int hashCode = -1128200109;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(Imagem);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Titulo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Descricao);
            hashCode = hashCode * -1521134295 + Duracao.GetHashCode();
            return hashCode;
        }

        public override string Validar()
        {
            if (string.IsNullOrEmpty(Titulo))
                return "Titulo é um campo obrigatório";

            if(string.IsNullOrEmpty(Descricao))
                return "Descrição é um campo obrigatório";

            if (TimeSpan.Zero == Duracao)
                return "Duração é um campo obrigatório";

            return "ESTA_VALIDO";
        }

    }
}
