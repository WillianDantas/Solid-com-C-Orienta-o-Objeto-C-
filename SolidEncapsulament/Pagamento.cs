using System;
using System.Collections.Generic;
using System.Text;

namespace SolidEncapsulament
{
    public class Pagamento
    {
        public double Valor { get; set; }
        public MeioDePagamento Forma { get; private set; }

        public Pagamento(double valor, MeioDePagamento forma)
        {
            this.Valor = valor;
            this.Forma = forma;
        }
    }
}
