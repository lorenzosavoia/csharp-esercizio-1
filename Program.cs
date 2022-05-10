using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Inserisci il primo numero:");

            int iPrimoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il secondo mumero:");

            int iSecondoNumero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("La moltiplicazione é: {0}",multiplication(iPrimoNumero, iSecondoNumero));

        }

        static int multiplication(int v1 , int v2)
        {
            return v1 * v2;
        }
    }
}