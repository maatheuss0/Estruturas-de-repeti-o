using System;

namespace senha_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            bool resposta = false;
            do
            {
                Console.WriteLine("Escreva seu nome de usuário: ");
                string respostaUsuario = Console.ReadLine();

                Console.WriteLine("Escreva sua senha: ");
                string respostaSenha = Console.ReadLine();

                if (respostaUsuario == respostaSenha)
                {
                    do
                    {
                        Console.WriteLine("A sua senha e nome de usuário são iguais");
                        Console.WriteLine("Escreva sua senha: ");
                        respostaSenha = Console.ReadLine();

                    } while ( respostaUsuario == respostaSenha);    
                    resposta = true;  
                }
                else
                {
                    resposta = true;
                }
            } while (resposta == false);
        }
    }
}
