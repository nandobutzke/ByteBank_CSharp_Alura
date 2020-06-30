using ByteBank_Alura_CSharp.Contas;
using ByteBank_Alura_CSharp.Exceções;
using ByteBank_Alura_CSharp.Funcionarios;
using ByteBank_Alura_CSharp.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Alura_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {

            CriarContas();
            UsuarioLogar();

            TestarExceptions();

            Console.ReadLine();
        }

        public static void CriarContas()
        {
            ContaCorrente contaDoNando = new ContaCorrente(234, 81299);
            Cliente nando = new Cliente();

            contaDoNando.Titular = nando;

            contaDoNando.Titular.Nome = "Fernando";

            Console.WriteLine(contaDoNando.Titular.Nome);
            
            Console.ReadLine();
        }

        public static void UsuarioLogar()
        {
            Diretor nando = new Diretor("192.173.822-91");
            nando.Nome = "Fernando";

            nando.Senha = "123";

            SistemaInterno sistema = new SistemaInterno();

            sistema.Logar(nando, "123");

        }

        public static void CriarUsuario()
        {
            Funcionario jorge = new Designer("128.923.843-01");

            jorge.Nome = "Jorge";
        }

        public static void TestarExceptions()
        {
            try
            {
                ContaCorrente testeConta = new ContaCorrente(121, 87292);
                ContaCorrente testeConta2 = new ContaCorrente(123, 18223);

                testeConta.Sacar(1000);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);


            }
            
            
            //catch(ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
