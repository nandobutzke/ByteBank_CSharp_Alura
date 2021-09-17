using ByteBank_Alura_CSharp.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Alura_CSharp.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(senha);
            
            if(usuarioAutenticado)
            {
                Console.WriteLine("Seja Bem-vindo");
                return true;
            }
            else
            {
                Console.WriteLine("Senha inválida");
                return false;
            }
        }
    }
}
