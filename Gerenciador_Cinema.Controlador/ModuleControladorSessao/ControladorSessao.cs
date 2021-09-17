using Gerenciador_Cinema.Controlador.Shared;
using Gerenciador_Cinema.Dominio.ModuleFilme;
using Gerenciador_Cinema.Dominio.ModuleSala;
using Gerenciador_Cinema.Dominio.ModuleSessao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.Controlador.ModuleControladorSessao
{
    public class ControladorSessao : Controlador<Sessao>
    {
        private const string sqlInserirSessao =
            @"INSERT INTO TBSESSAO
	                (
		                [Data], 
		                [HorarioInicial], 
		                [HorarioFinal], 
		                [ValorIngresso], 
		                [TipoAnimacao], 
		                [TipoAudio], 
		                [Id_Filme], 
		                [Id_Sala]
	                ) 
	                VALUES
	                (
                        @Data, 
                        @HorarioInicial, 
                        @HorarioFinal, 
                        @ValorIngresso, 
                        @TipoAnimacao, 
                        @TipoAudio, 
                        @Id_Filme, 
                        @Id_Sala
	                )";

        private const string sqlEditarSessao =
            @"UPDATE TBSESSAO
                    SET
                        [Data] = @Data, 
		                [HorarioInicial] = HorarioInicial, 
		                [HorarioFinal] = HorarioFinal, 
		                [ValorIngresso] = ValorIngresso, 
		                [TipoAnimacao] = TipoAnimacao, 
		                [TipoAudio] = TipoAudio, 
		                [Id_Filme] = Id_Filme, 
		                [Id_Sala] = Id_Sala
                    WHERE 
                        ID = @Id";

        private const string sqlExcluirSessao =
            @"DELETE 
	                FROM
                        TBSESSAO
                    WHERE 
                        Id = @Id";

        private const string sqlSelecionarSessaoPorId =
            @"SELECT
                        TS.[Data], 
		                TS.[HorarioInicial], 
		                TS.[HorarioFinal], 
		                TS.[ValorIngresso], 
		                TS.[TipoAnimacao], 
		                TS.[TipoAudio], 
		                TS.[Id_Filme], 
		                TS.[Id_Sala],
                        TF.[Imagem],
                        TF.[Titulo],
                        TF.[Descricao],
                        TF.[Duracao],
                        TA.[Nome],
                        TA.[QtdAssentos],
	                FROM
                        TBSESSAO AS TS 
                    LEFT JOIN
                        TBFILME AS TF 
                    ON
                        TF.Id = TS.Id_Filme
                    LEFT JOIN 
                        TBSALA AS TA
                    ON
                        TA.Id = TS.Id_Sala
                    WHERE 
                        Id = @Id;";

        private const string sqlSelecionarTodosSessaos =
            @"SELECT
                        TS.[Data], 
		                TS.[HorarioInicial], 
		                TS.[HorarioFinal], 
		                TS.[ValorIngresso], 
		                TS.[TipoAnimacao], 
		                TS.[TipoAudio], 
		                TS.[Id_Filme], 
		                TS.[Id_Sala],
                        TF.[Imagem],
                        TF.[Titulo],
                        TF.[Descricao],
                        TF.[Duracao],
                        TA.[Nome],
                        TA.[QtdAssentos],
	                FROM
                        TBSESSAO AS TS 
                    LEFT JOIN
                        TBFILME AS TF 
                    ON
                        TF.Id = TS.Id_Filme
                    LEFT JOIN 
                        TBSALA AS TA
                    ON
                        TA.Id = TS.Id_Sala;";

        private const string sqlExisteSessao =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBSESSAO]
            WHERE 
                [Id] = @Id";

        private const string sqlVerificarHorarioOcupado =
            @"SELECT
	            COUNT(*)
            FROM 
	            TBSESSAO
            WHERE 
                [Data] = @Data 
            AND 
                @HoraInicialDesejada BETWEEN HorarioInicial AND HorarioFinal 
            OR 
                @HoraFinalDesejada BETWEEN HorarioInicial AND HorarioFinal";

        public override string Inserir(Sessao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = ConexaoDB.Insert(sqlInserirSessao, ObtemParametrosSessao(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Sessao registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                ConexaoDB.Update(sqlEditarSessao, ObtemParametrosSessao(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                ConexaoDB.Delete(sqlExcluirSessao, AdicionarParametro("Id", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return ConexaoDB.Exists(sqlExisteSessao, AdicionarParametro("Id", id));
        }

        public override Sessao SelecionarPorId(int id)
        {
            return ConexaoDB.Get(sqlSelecionarSessaoPorId, ConverterEmSessao, AdicionarParametro("Id", id));
        }

        public override List<Sessao> SelecionarTodos()
        {
            return ConexaoDB.GetAll(sqlSelecionarTodosSessaos, ConverterEmSessao);
        }

        private Dictionary<string, object> ObtemParametrosSessao(Sessao sessao)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", sessao.Id);
            parametros.Add("Data", sessao.Data);
            parametros.Add("HorarioInicial", sessao.HorarioInicial);
            parametros.Add("HorarioFInal", sessao.HorarioFInal);
            parametros.Add("ValorIngresso", sessao.ValorIngresso);
            parametros.Add("TipoAnimacao", sessao.TipoAnimacao);
            parametros.Add("TipoAudio", sessao.TipoAudio);
            parametros.Add("Filme", sessao.Filmes?.Id);
            parametros.Add("Sala", sessao.Salas?.Id);

            return parametros;
        }

        private Sessao ConverterEmSessao(IDataReader reader)
        {
            //itens do filme
            var imagem = (reader["Foto"] != DBNull.Value) ? (byte[])reader["Imagem"] : null;
            var titulo = Convert.ToString(reader["Titulo"]);
            var descricao = Convert.ToString(reader["Descricao"]);
            var duracao = TimeSpan.FromTicks(Convert.ToInt64(reader["Duracao"]));

            Filme filme = new Filme(imagem, titulo, descricao, duracao);
            filme.Id = Convert.ToInt32(reader["Id_Filme"]);

            //itens da sala
            var nome = Convert.ToString(reader["Nome"]);
            var qtdAssentos = Convert.ToInt32(reader["QtdAssentos"]);

            Sala sala = new Sala(nome, qtdAssentos);
            sala.Id = Convert.ToInt32(reader["Id_Sala"]);

            //itens da sessão
            var id = Convert.ToInt32(reader["Id"]);
            var data = Convert.ToDateTime(reader["Data"]);
            var horarioInicial = TimeSpan.FromTicks(Convert.ToInt64(reader["HorarioInicial"]));
            var horarioFInal = TimeSpan.FromTicks(Convert.ToInt64(reader["HorarioFInal"]));
            var valorIngresso = Convert.ToDecimal(reader["ValorIngresso"]);
            var tipoAnimacao = Convert.ToString(reader["TipoAnimacao"]);
            var tipoAudio = Convert.ToString(reader["TipoAudio"]);

            Sessao sessao = new Sessao(data, horarioInicial, horarioFInal, valorIngresso, tipoAnimacao, tipoAudio, filme, sala);

            sessao.Id = id;

            return sessao;
        }

        public bool VerificarHorarioOcupado(DateTime data, TimeSpan horaInicioDesejado, TimeSpan horaTerminoDesejado)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Data", data);

            parametros.Add("HoraInicialDesejada", horaInicioDesejado.Ticks);
            parametros.Add("HoraFinalDesejada", horaTerminoDesejado.Ticks);

            return ConexaoDB.Exists(sqlVerificarHorarioOcupado, parametros);
        }

    }
}
