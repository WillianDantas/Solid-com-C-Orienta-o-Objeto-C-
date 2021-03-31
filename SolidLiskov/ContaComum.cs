using System;
using System.Collections.Generic;
using System.Text;

namespace SolidLiskov
{
    public class ContaComum
    {
        public double Saldo { get; protected set; }

      
 

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Saca(double valor)
        {
            if(valor <= this.Saldo)
            {
                this.Saldo -= valor;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public virtual void SomaInvestimento()
        {
            if(this.Saldo > 0)
            {
                this.Saldo += this.Saldo * 0.01;
            }
            
        }

    }
}
