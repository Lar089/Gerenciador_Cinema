using Gerenciador_Cinema.Controlador.Shared;
using Gerenciador_Cinema.Dominio.ModuleLogin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.Controlador.ModuleControladorLogin
{
    public class ControladorLogin : Controlador<Login>
    {
        private const string sqlInserirLogin =
            @"INSERT INTO TBLOGIN
	                (
		                [Email], 
		                [Senha] 
	                ) 
	                VALUES
	                (
                        @Email, 
                        @Senha
	                )";

        private const string sqlEditarLogin =
            @"UPDATE TBLOGIN
                    SET
                        [Email] = @Email,
		                [Senha] = @Senha
                    WHERE 
                        ID = @Id";

        private const string sqlExcluirLogin =
            @"DELETE 
	                FROM
                        TBLOGIN
                    WHERE 
                        Id = @Id";

        private const string sqlSelecionarLoginPorId =
            @"SELECT
                        [Id],
		                [Email], 
		                [Senha]
	                FROM
                        TBLOGIN
                    WHERE 
                        Id = @Id";

        private const string sqlSelecionarTodosLogins =
            @"SELECT
                        [Id],
		                [Email], 
		                [Senha]
	                FROM
                        TBLOGIN;";

        private const string sqlExisteLogin =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBLOGIN]
            WHERE 
                [Id] = @Id";

        public override string Inserir(Login registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = ConexaoDB.Insert(sqlInserirLogin, ObtemParametrosLogin(registro));
            }

            return resultadoValidacao;
        }

        public override string Editar(int id, Login registro)
        {
            string resultadoValidacao = registro.Validar();

            if (resultadoValidacao == "ESTA_VALIDO")
            {
                registro.Id = id;
                ConexaoDB.Update(sqlEditarLogin, ObtemParametrosLogin(registro));
            }

            return resultadoValidacao;
        }

        public override bool Excluir(int id)
        {
            try
            {
                ConexaoDB.Delete(sqlExcluirLogin, AdicionarParametro("Id", id));
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public override bool Existe(int id)
        {
            return ConexaoDB.Exists(sqlExisteLogin, AdicionarParametro("Id", id));
        }

        public override Login SelecionarPorId(int id)
        {
            return ConexaoDB.Get(sqlSelecionarLoginPorId, ConverterEmLogin, AdicionarParametro("Id", id));
        }

        public override List<Login> SelecionarTodos()
        {
            return ConexaoDB.GetAll(sqlSelecionarTodosLogins, ConverterEmLogin);
        }

        private Dictionary<string, object> ObtemParametrosLogin(Login login)
        {
            var parametros = new Dictionary<string, object>();

            parametros.Add("Id", login.Id);
            parametros.Add("Email", login.Email);
            parametros.Add("Senha", login.Senha);

            return parametros;
        }

        private Login ConverterEmLogin(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["Id"]);
            var email = Convert.ToString(reader["Email"]);
            var senha = Convert.ToString(reader["Senha"]);

            Login login = new Login(email, senha);

            login.Id = id;

            return login;
        }
    }
}
