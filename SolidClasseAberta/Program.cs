using System;

namespace SolidClasseAberta
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra(500, "sao paulo");
            CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecoPadrao(), new Transportadora());

            double resultado = calc.Calcula(compra);

            Console.WriteLine("O preco da compra e :" + resultado);
            Console.ReadKey();


        }
    }
}
