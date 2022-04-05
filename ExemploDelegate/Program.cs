using System;

namespace ExemploDelegate
{
    public delegate void SimplesDelegate();
    public class Program
    {
        public static void Main(string[] args)
        {
            // Instanciação
            SimplesDelegate simplesDelegate = new SimplesDelegate(ExemploDeDelegate.MyFunction);

            // Invocação da função
            simplesDelegate();
            Console.ReadKey();
        }
    }
}
