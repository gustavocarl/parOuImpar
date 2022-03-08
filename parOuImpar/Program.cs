using System;

namespace parOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroNumero, segundoNumero, soma;
            Console.WriteLine("Por favor, informe um número! ");
            primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor, insira o segundo número: ");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            soma = primeiroNumero + segundoNumero;
            if (soma % 2 == 0)
                Console.WriteLine("O número {0} é par!", soma);
            else
                Console.WriteLine("O número {0} é impar!", soma);
            Console.ReadKey();
        }
    }
}
