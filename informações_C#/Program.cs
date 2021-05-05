using System;

namespace informações_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resposta = false;
            do
            {
                Console.WriteLine("Escreva seu nome: ");
                string respostaNome = Console.ReadLine();
                
                Console.WriteLine("Escreva sua idade: ");
                int respostaIdade = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Escreva seu salário: ");
                int respostaSalario = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Escreva seu estado civil: ");
                string respostaCivil = Console.ReadLine();

                
                
            } while (true);
        }
    }
}
