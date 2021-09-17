using Gerenciador_Cinema.Dominio.ModuleFilme;
using Gerenciador_Cinema.Dominio.ModuleSala;
using Gerenciador_Cinema.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.Dominio.ModuleSessao
{
    public class Sessao : EntidadeBase
    {
        public DateTime Data { get; }
        public TimeSpan HorarioInicial { get; }
        public TimeSpan HorarioFInal { get; }
        public decimal ValorIngresso { get; }
        public string TipoAnimacao { get; }
        public string TipoAudio { get; }
        public Filme Filmes { get; }
        public Sala Salas { get; }

        public Sessao(DateTime data, TimeSpan horarioInicial, TimeSpan horarioFInal, decimal valorIngresso, 
            string tipoAnimacao, string tipoAudio, Filme filmes, Sala salas)
        {
            Data = data;
            HorarioInicial = horarioInicial;
            HorarioFInal = horarioFInal;
            ValorIngresso = valorIngresso;
            TipoAnimacao = tipoAnimacao;
            TipoAudio = tipoAudio;
            Filmes = filmes;
            Salas = salas;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Sessao);
        }

        public bool Equals(Sessao obj)
        {
            return obj is Sessao sessao &&
                   Data == sessao.Data &&
                   HorarioInicial.Equals(sessao.HorarioInicial) &&
                   HorarioFInal.Equals(sessao.HorarioFInal) &&
                   ValorIngresso == sessao.ValorIngresso &&
                   TipoAnimacao == sessao.TipoAnimacao &&
                   TipoAudio == sessao.TipoAudio &&
                   EqualityComparer<Filme>.Default.Equals(Filmes, sessao.Filmes) &&
                   EqualityComparer<Sala>.Default.Equals(Salas, sessao.Salas);
        }

        public override int GetHashCode()
        {
            int hashCode = 1934698402;
            hashCode = hashCode * -1521134295 + Data.GetHashCode();
            hashCode = hashCode * -1521134295 + HorarioInicial.GetHashCode();
            hashCode = hashCode * -1521134295 + HorarioFInal.GetHashCode();
            hashCode = hashCode * -1521134295 + ValorIngresso.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TipoAnimacao);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TipoAudio);
            hashCode = hashCode * -1521134295 + EqualityComparer<Filme>.Default.GetHashCode(Filmes);
            hashCode = hashCode * -1521134295 + EqualityComparer<Sala>.Default.GetHashCode(Salas);
            return hashCode;
        }

        public override string Validar()
        {
            if (ValorIngresso <= 0)
                return "Valor do ingresso inválido";

            return "ESTA_VALIDO";
        }
    }
}
