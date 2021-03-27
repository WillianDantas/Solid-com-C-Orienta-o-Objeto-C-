using System;
using System.Collections.Generic;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario cs = new CalculadoraDeSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000);
            double resultado;


            resultado = cs.Calcula(funcionario);
            Console.WriteLine("O salario de um desenvolvedor que ganha 2000 bruto é :" + resultado);
            Console.ReadKey();

            EnviadorDeEmail enviadorDeEmail = new EnviadorDeEmail();
            NotaFiscalDao nfDao = new NotaFiscalDao();
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();
            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDao());
            GeradorDeNotaFiscal gnf = new GeradorDeNotaFiscal(acoes);
            Fatura fatura = new Fatura("Renan", 200);

            gnf.Gera(fatura);
            Console.ReadKey();
        }
    }
}
