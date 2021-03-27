using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class GeradorDeNotaFiscal
    {
        // private EnviadorDeEmail enviadorDeEmail;
        // private NotaFiscalDao notaFiscalDao;


        // Resolver acomplamento a coisas(metodos) que mudam

        /*
        public GeradorDeNotaFiscal(IAcaoAposGerarNota enviadorDeEmail, IAcaoAposGerarNota notaFiscalDao)
        {
            this.enviadorDeEmail = enviadorDeEmail;
            this.notaFiscalDao = notaFiscalDao;
        }
        */

        private IList<IAcaoAposGerarNota> acoes;

        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            this.acoes = acoes;
        }

        /*

        public NotaFiscal Gera(Fatura fatura)
        
            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreValor(valor));

            enviadorDeEmail.EnviaEmail(nf);
            notaFiscalDao.Persiste(nf);

            return nf;
        }

        */

        public NotaFiscal Gera(Fatura fatura)
        {
            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreValor(valor));

            foreach(var acao in acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        private double ImpostoSimplesSobreValor(double valor)
        {
            return valor * 0.06;
        }
    }
}
