using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    class EnviadorDeEmail : IAcaoAposGerarNota
    {

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando email");
        }
    }
}
