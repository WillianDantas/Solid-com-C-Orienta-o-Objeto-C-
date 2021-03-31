using System;
using System.Collections.Generic;
using System.Text;

namespace SolidEncapsulament
{
    public class ProcessadorDeBoletos
    {
        public void Processa(List<Boleto> boletos, Fatura fatura)
        {

            foreach(Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.AdicionaPagamento(pagamento);

                total += boleto.Valor;
            }

            
        }
    }
}
