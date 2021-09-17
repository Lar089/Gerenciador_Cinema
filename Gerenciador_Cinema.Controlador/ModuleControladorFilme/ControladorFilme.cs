using Gerenciador_Cinema.Controlador.Shared;
using Gerenciador_Cinema.Dominio.ModuleFilme;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.Controlador.ModuleControladorFilme
{
    public class ControladorFilme : Controlador<Filme>
    {
        private const string sqlInserirFilme =
            @"INSERT INTO TBFILME
	                (
		                [Imagem], 
		                [Titulo], 
		                [Descricao],
                        [Duracao]
	                ) 
	                VALUES
	                (
                        @Imagem, 
                        @Titulo,
                        @Descricao,
		                @Duracao
	                )";

        private const string sqlEditarFilme =
            @"UPDATE TBFILME
                    SET
                        [Imagem] = @Imagem,
		                [Titulo] = @Titulo, 
		                [Descricao] = @Descricao,
                        [Duracao] = @Duracao
                    WHERE 
                        ID = @Id";

        private const string sqlExcluirFilme =
            @"DELETE 
	                FROM
                        TBFILME
                    WHERE 
                        Id = @Id";

        private const string sqlSelecionarFilmePorId =
            @"SELECT
                        [Id],
		                [Imagem], 
		                [Titulo], 
		                [Descricao],
                        [Duracao]
	                FROM
                        TBFILME
                    WHERE 
                        Id = @Id";

        private const string sqlSelecionarTodosFilmes =
            @"SELECT
                        [Id],
		                [Imagem], 
		                [Titulo], 
		                [Descricao],
                        [Duracao]
	                FROM
                        TBFILME;";

        private const string sqlExisteFilme =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBFILME]
            WHERE 
                [Id] = @Id";


        public override string Inserir(Filme registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = ConexaoDB.Insert(sqlInserirFilme, ObtemParametrosFilme(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Filme registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                ConexaoDB.Update(sqlEditarFilme, ObtemParametrosFilme(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                ConexaoDB.Delete(sqlExcluirFilme, AdicionarParametro("Id", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return ConexaoDB.Exists(sqlExisteFilme, AdicionarParametro("Id", id));
        }

        public override Filme SelecionarPorId(int id)
        {
            return ConexaoDB.Get(sqlSelecionarFilmePorId, ConverterEmFilme, AdicionarParametro("Id", id));
        }

        public override List<Filme> SelecionarTodos()
        {
            return ConexaoDB.GetAll(sqlSelecionarTodosFilmes, ConverterEmFilme);
        }

        private Dictionary<string, object> ObtemParametrosFilme(Filme filme)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", filme.Id);
            parametros.Add("Imagem", filme.Imagem);
            parametros.Add("Titulo", filme.Titulo);
            parametros.Add("Descricao", filme.Descricao);
            parametros.Add("Duracao", filme.Duracao);

            return parametros;
        }

        private Filme ConverterEmFilme(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["Id"]);
            var imagem = (reader["Foto"] != DBNull.Value) ? (byte[])reader["Imagem"] : null;
            var titulo = Convert.ToString(reader["Titulo"]);
            var descricao = Convert.ToString(reader["Descricao"]);
            var duracao = Convert.ToDateTime(reader["Duracao"]).TimeOfDay;

            Filme filme = new Filme(imagem, titulo, descricao, duracao);

            filme.Id = id;

            return filme;
        }
    }
}
