# ✅ SOLID : Orientação a Objetos com C #
| Letra  |  Sigla |  Nome  | Definição |
| :------------ | :------------ | :------------ |  :------------ |
| S |  SRP  |  	Principio da Responsabilidade Única  |  Uma classe deve ter um, e somente um, motivo para mudar. |
| O  | OCP |  Princípio Aberto-Fechado |  Você deve ser capaz de estender um comportamento de uma classe, sem modificá-lo. |
| L  |  LSP  |  Princípio da Substituição de Liskov  | As classes base devem ser substituíveis por suas classes derivadas. |
| I  |  ISP  |  Princípio da Segregação da Interface  | Muitas interfaces específicas são melhores do que uma interface única. |
| D |  DIP  |  Princípio da inversão da dependência  | Dependa de uma abstração e não de uma implementação. |


##  Coesão e o Single Responsibility Principle

- Uma classe deve ter um, e somente um, motivo para mudar.
-  Como trona uma classe coesa e não coesa :
 - Então, encontrou uma classe com muita responsabilidade, divida-a em várias classes menores.
- Exemplo de classe não coesa sempre estara crescendo e mudando.
```csharp
class CalculadoraDeSalario
    {  

        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.Cargo is Desenvolvedor)
            {
                return  DezOuVintePorcento(funcionario);
            }
            
            if(funcionario.Cargo is Dba || funcionario.Cargo is Tester)
            {
                return QuinzeOuVinteCincoPorcento(funcionario);
            }

            throw new Exception("funcionario invalido");
        }

       
       
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
      
    }
```

- Exemplo de classe  coesa.
```csharp
class CalculadoraDeSalario
    {


        public double Calcula(Funcionario funcionario)
        {
            return funcionario.CalculaSalario();
        }

    }
```

```csharp
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
```

```csharp
 public abstract class Cargo
    {
        public IRegraDeCalculo Regra { get; private set; }

        public Cargo(IRegraDeCalculo regra)
        {
            this.Regra = regra;
        }
    }
```

```csharp
   class DezOuVintePorcento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if(funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.8;
            }
            else
            {
                return funcionario.SalarioBase * 0.9;
            }

        }
    }
```

##   Acoplamento e a estabilidade

- Grande problema o acoplamento se depende de muitas classes se a mudança, essa mudança pode se propagar. Acabando gerando bugs no sistema.
- Observação : Tem que saber dividir. Saber quando acoplamento e prejudicial ou não.




- Comando Git 
git push -f origin master