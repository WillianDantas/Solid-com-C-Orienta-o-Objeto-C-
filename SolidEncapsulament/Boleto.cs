using System;
using System.Collections.Generic;
using System.Text;

namespace SolidEncapsulament
{
    public class Boleto
    {
        public double Valor { get; set; }

        public Boleto(double valor)
        {
            this.Valor = valor;
        }
    }
}
