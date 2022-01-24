using System;

namespace ExercicoPositivoNegativo
{
    class Program
    {
        static void Main(string[] args)
        {   
            int numero;

            Console.Write("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if(numero >= 0)
            {
                Console.WriteLine($"O número {numero} é positivo.");   
            }
            else
            {
                Console.WriteLine($"O número {numero} é negativo.");   
            }
        }
    }
}