using System;
using System.Collections.Generic;
using System.Text;

namespace SolidEncapsulament
{
    public class Fatura
    {
        public string Cliente { get; set; }
        public double Valor { get; set; }
        private IList<Pagamento> Pagamentos { get; set; }
        public bool Pago { get; private set; }

        public Fatura(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
            this.Pago = false;
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            this.Pagamentos.Add(pagamento);

            if(ValorTotalDosPagamentos() >= Valor)
            {
                this.Pago = true;
            }
        }


        private double ValorTotalDosPagamentos()
        {
            double total = 0;

            foreach(Pagamento pag in Pagamentos)
            {
                total += pag.Valor;
            }

            return total;
        }
    }
}
