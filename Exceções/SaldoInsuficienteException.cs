using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Alura_CSharp.Exceções
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double ValorSaque { get; }
        public double Saldo { get; }

        public SaldoInsuficienteException() { }

        public SaldoInsuficienteException(double valorSaque, double saldo)
            : this("O saque no valor de " + valorSaque + " não pode ser efetuado " +
                  "pois o saldo é de " + saldo)
        {
            ValorSaque = valorSaque;
            Saldo = saldo;
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem) { }

        public SaldoInsuficienteException(string mensagem, Exception exceptionInterna) 
            : base(mensagem, exceptionInterna)
        {

        }
    }
}
