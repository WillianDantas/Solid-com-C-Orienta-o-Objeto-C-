using System;
using System.Collections.Generic;

namespace SolidEncapsulament
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Boleto> boletos = new List<Boleto>();
            boletos.Add(new Boleto(200));
            boletos.Add(new Boleto(300));
            boletos.Add(new Boleto(400));

            Fatura fatura = new Fatura("Caelum", 900);

            ProcessadorDeBoletos pdb = new ProcessadorDeBoletos();

            pdb.Processa(boletos, fatura);

            Console.WriteLine(fatura.Pago);
            Console.ReadKey();
        }
    }
}
