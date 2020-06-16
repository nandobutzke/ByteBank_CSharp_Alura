using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Alura_CSharp.Contas
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private int _agencia;
        public int Agencia {
            get
            {
                return _agencia;
            } 
            set 
            { 
                if(value <= 0)
                {
                    Console.WriteLine("Agência Inválida.");
                }
                else
                {
                    _agencia = value;
                }
            } 
        }
        private int _numero;
        public int Numero { 
            get 
            {
                return _numero;
            } 
            set 
            {
                if(value <= 0)
                {
                    Console.WriteLine("Número de conta inválido.");
                }
                else
                {
                    _numero = value;
                }
            } 
        }
        public double Saldo { get; set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
        }

        public double Depositar(double valor)
        {
            return this.Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if(valor <= 0)
            {
                return false;
            }
            else
            {
                this.Saldo -= valor;
                return true;
            }
        }
        public bool Transferir(ContaCorrente contaDestino, double valor)
        {
            if(valor <= 0)
            {
                return false;
            }
            else
            {
                this.Saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
