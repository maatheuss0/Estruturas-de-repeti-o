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

                if (respostaNome == "")
                {
                    Console.WriteLine("Por favor, insira um nome existente");
                    Console.WriteLine("Escreva seu nome: ");
                    respostaNome = Console.ReadLine();
                }
                else
                {
                    resposta = true;
                }

            }while (resposta == false);

            Console.WriteLine("Escreva sua idade: ");
            int respostaIdade = int.Parse(Console.ReadLine());
            


        }
    }
}
