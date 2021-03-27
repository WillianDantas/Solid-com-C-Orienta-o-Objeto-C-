using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class Fatura
    {
        public string Nome { get; set; }
        public double ValorMensal { get; set; }

        public Fatura(String nome, double valorMensal)
        {
            this.Nome = nome;
            this.ValorMensal = valorMensal;
        }

        
    }
}
