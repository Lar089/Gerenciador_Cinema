using Gerenciador_Cinema.Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciador_Cinema.Dominio.ModuleLogin
{
    public class Login : EntidadeBase
    {
        public string Email { get; }
        public string Senha { get; }

        public Login(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Login);
        }

        public bool Equals(Login obj)
        {
            return obj is Login login &&
                   Email == login.Email &&
                   Senha == login.Senha;
        }

        public override int GetHashCode()
        {
            int hashCode = -1397370338;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Senha);
            return hashCode;
        }

        public override string Validar()
        {
            return "ESTA_VALIDO";
        }
    }
}
