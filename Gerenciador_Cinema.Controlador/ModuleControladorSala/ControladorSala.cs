using Gerenciador_Cinema.Controlador.Shared;
using Gerenciador_Cinema.Dominio.ModuleSala;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.Controlador.ModuleControladorSala
{
    public class ControladorSala : Controlador<Sala>
    {
        private const string sqlInserirSala =
            @"INSERT INTO TBSALA
	                (
		                [Nome], 
		                [QtdAssentos], 
	                ) 
	                VALUES
	                (
                        @Nome, 
                        @QtdAssentos
	                )";

        private const string sqlEditarSala =
            @"UPDATE TBSALA
                    SET
                        [Nome] = @Nome,
		                [QtdAssentos] = @QtdAssentos
                    WHERE 
                        ID = @Id";

        private const string sqlExcluirSala =
            @"DELETE 
	                FROM
                        TBSALA
                    WHERE 
                        Id = @Id";

        private const string sqlSelecionarSalaPorId =
            @"SELECT
                        [Id],
		                [Nome], 
		                [QtdAssentos]
	                FROM
                        TBSALA
                    WHERE 
                        Id = @Id";

        private const string sqlSelecionarTodosSalas =
            @"SELECT
                        [Id],
		                [Nome], 
		                [QtdAssentos]
	                FROM
                        TBSALA;";

        private const string sqlExisteSala =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBSALA]
            WHERE 
                [Id] = @Id";

        public override string Inserir(Sala registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = ConexaoDB.Insert(sqlInserirSala, ObtemParametrosSala(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Sala registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                ConexaoDB.Update(sqlEditarSala, ObtemParametrosSala(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                ConexaoDB.Delete(sqlExcluirSala, AdicionarParametro("Id", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return ConexaoDB.Exists(sqlExisteSala, AdicionarParametro("Id", id));
        }

        public override Sala SelecionarPorId(int id)
        {
            return ConexaoDB.Get(sqlSelecionarSalaPorId, ConverterEmSala, AdicionarParametro("Id", id));
        }

        public override List<Sala> SelecionarTodos()
        {
            return ConexaoDB.GetAll(sqlSelecionarTodosSalas, ConverterEmSala);
        }

        private Dictionary<string, object> ObtemParametrosSala(Sala sala)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", sala.Id);
            parametros.Add("Nome", sala.Nome);
            parametros.Add("QtdAssentos", sala.QtdAssentos);

            return parametros;
        }

        private Sala ConverterEmSala(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["Id"]);
            var nome = Convert.ToString(reader["Nome"]);
            var qtdAssentos = Convert.ToInt32(reader["QtdAssentos"]);

            Sala sala = new Sala(nome, qtdAssentos);

            sala.Id = id;

            return sala;
        }

    }
}
