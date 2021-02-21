using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class Funcionario
    {

        public Cargo Cargo { get; private set; }
        public double SalarioBase { get; set; }

        public Funcionario(Cargo cargo, double salarioBase)
        {
            this.Cargo = cargo;
            this.SalarioBase = salarioBase;
        }

        public  double CalculaSalario()
        {
           return this.Cargo.Regra.Calcula(this);
        }
        
    }
}
