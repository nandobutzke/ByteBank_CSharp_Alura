﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Alura_CSharp.Exceções
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException() { }

        public OperacaoFinanceiraException(string mensagem) : base(mensagem) { }

        public OperacaoFinanceiraException(string mensagem, Exception innerException) 
            : base(mensagem, innerException) { }
    }
}
