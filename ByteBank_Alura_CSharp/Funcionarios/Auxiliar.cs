using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Alura_CSharp.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2500, cpf) { }

        public override double GetBonificacao()
        {
            return Salario * 0.16;
        }

        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.05);
        }
    }
}
