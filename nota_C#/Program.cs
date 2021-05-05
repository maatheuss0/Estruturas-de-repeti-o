using System;

namespace nota_C
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta = false;
            do
            {
                Console.WriteLine("Escreva um número de 0 a 10");
                int numero = int.Parse(Console.ReadLine());

                if ( numero > 10)
                {
                    Console.WriteLine("Número inválido!!!");
                }

                else
                {
                    Console.WriteLine("Número válido");
                    Console.WriteLine("Execução Finalizada!!!");
                    resposta = true;
                }
                

            } while (resposta == false);
        }
    }
}
