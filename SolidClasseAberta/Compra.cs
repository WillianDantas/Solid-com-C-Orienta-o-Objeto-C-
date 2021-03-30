using System;
using System.Collections.Generic;
using System.Text;

namespace SolidClasseAberta
{
    public class Compra
    {
        public double Valor { get; set; }
        public string Cidade { get; set; }

        public  Compra (double valor, string cidade)
        {
            this.Valor = valor;
            this.Cidade = cidade;
        }
    }
}
