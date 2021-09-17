using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Alura_CSharp.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            CPF = cpf;
        }

        public abstract double GetBonificacao();
        public abstract void AumentarSalario();

    }
}
