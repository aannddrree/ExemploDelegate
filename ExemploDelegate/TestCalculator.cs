using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDelegate
{
    public class TestCalculator
    {
        public static void Main (String[] args)
        {

            //criando a instância da classe a qual contém os métodos
            //que serão atribuidos aos objetos delegates
            Calculator calc = new Calculator();

            //criando objetos delegates e atribuindo os métodos apropriados
            //que possuem a assinatura EXATA do delegate
            Calcular Sum = new Calcular(calc.Sum);
            Calcular Subtract = new Calcular(calc.Subtract);
            Calcular Multiply = new Calcular(calc.Multiply);
            Calcular Divide = new Calcular(calc.Divide);

            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Subtract(1, 2));
            Console.WriteLine(Multiply(1, 2));
            Console.WriteLine(Divide(1, 2));

        }
    }
}
