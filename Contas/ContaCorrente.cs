using ByteBank_Alura_CSharp.Exceções;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Alura_CSharp.Contas
{
    public class ContaCorrente
    {
        private double innerException;

        public Cliente Titular { get; set; }
        public int TotalContasCriadas { get; }
        public double TaxaPrestacao { get; }
        public int Agencia { get; }
        public int Numero { get; }
        public double Saldo { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            if(agencia < 0)
            {
                throw new ArgumentException("Agência de conta inválida.", nameof(agencia));
            }

            if(numero < 0)
            {
                throw new ArgumentException("Número de conta inválido.", nameof(numero));
            }

            TotalContasCriadas++;
            TaxaPrestacao = 30 / TotalContasCriadas;
        }

        public double Depositar(double valor)
        {
            return Saldo += valor;
        }
        public void Sacar(double valor)
        {
            if(valor <= 0)
            {
                throw new OperacaoFinanceiraException("O valor do saque é inválido.");
            }

            if(Saldo <= 0)
            {
                throw new SaldoInsuficienteException(valor, Saldo);
            }
            
        }
        public void Transferir(ContaCorrente contaDestino, double valor)
        {
            if(valor <= 0)
            {
                throw new OperacaoFinanceiraException("O valor da transferência é inválido.");
            }


            try
            {
                Sacar(valor);
            }
            catch(OperacaoFinanceiraException)
            {
                Console.WriteLine("O valor do saque é inválido");
            }
            
            contaDestino.Depositar(valor);
                
            
        }
    }
}
