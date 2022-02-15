using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
   static class CadastroUsuarios
    {
        private static Usuario[] usuarios =
        {
            new Usuario{Nome = "flavio", Senha = "123456"},
            new Usuario{Nome = "girlene", Senha = "654321"},
            new Usuario{Nome = "teste", Senha = "teste"}
        };

        private static Usuario _userLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _userLogado; }
            private set { _userLogado = value; }
        }

        public static bool Login(string nome, string senha)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsuarioLogado = usuario;
                    return true;
                }

            }

            return false;
        }
    }
}
