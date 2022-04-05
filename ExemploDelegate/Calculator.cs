using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FONTE: https://www.macoratti.net/11/05/c_dlg1.htm
namespace ExemploDelegate
{
    public delegate int Calcular(int value1, int value2);
    public class Calculator
    {
        //o método Somar que será atribuido ao objeto delegate
        //e possui a assinatura EXATA do delegate
        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        //o método Subtrair que será atribuido ao objeto delegate
        //e possui a assinatura EXATA do delegate
        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }

        //o método Multiplicar que será atribuido ao objeto delegate
        //e possui a assinatura EXATA do delegate
        public int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }

        //o método Dividir que será atribuido ao objeto delegate
        //e possui a assinatura EXATA do delegate
        public int Divide(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}
