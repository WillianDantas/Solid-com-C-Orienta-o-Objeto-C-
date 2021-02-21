using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
     class CalculadoraDeSalario
    {


        public double Calcula(Funcionario funcionario)
        {
            return funcionario.CalculaSalario();
        }

        /*

        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Cargo is Desenvolvedor)
            {
                return new DezOuVintePorcento().Calcula(funcionario);
            }
            
            if(funcionario.Cargo is Dba || funcionario.Cargo is Tester)
            {
                return new QuinzeOuVinteCincoPorcento().Calcula(funcionario);
            }

            throw new Exception("funcionario invalido");
        }

        */
        /*
        private double DezOuVintePorcento(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.8;
            }
            else
            {
                return funcionario.SalarioBase * 0.9;
            }

        }

        private double QuinzeOuVinteCincoPorcento(Funcionario funcionario)
        {
            if(funcionario.SalarioBase > 2000.0)
            {
                return funcionario.SalarioBase * 0.75;
            }
            else
            {
                return funcionario.SalarioBase * 0.85;
            }

        }
       */
    }
}
